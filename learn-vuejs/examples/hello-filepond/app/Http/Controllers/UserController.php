<?php

namespace App\Http\Controllers;

use App\Http\Requests\UploadAvatarRequest;
use App\Models\TemporaryUploadedFile;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Storage;

class UserController extends Controller
{
    /**
     * NOTICE: controller was constructed before middlewares were passed
     */
    public function __construct()
    {
    }


    /**
     * Save file to temporary directory
     *
     * @param UploadAvatarRequest $request
     * @return \Illuminate\Http\Response
     */
    public function upload(UploadAvatarRequest $request)
    {
        $file = $request->file('avatar');
        $path = $file->store('temp');
        TemporaryUploadedFile::create([
            'client_original_name' => $file->getClientOriginalName(),
            'hash_name' => $file->hashName(),
            'disk' => 'local',
            'path_by_disk' => $path,
        ]);

        return response($file->hashName());
    }

    /**
     * Move temporary file to persistent storage
     *
     * @param Request $request
     * @return \Illuminate\Http\Response
     */
    public function submit(Request $request)
    {
        $user = Auth::user();
        $temporaryUploadedFile = TemporaryUploadedFile::where('hash_name', $request->avatar)->firstOrFail();
        $user->addMediaFromDisk($temporaryUploadedFile->path_by_disk, $temporaryUploadedFile->disk)
            ->toMediaCollection();
        $temporaryUploadedFile->delete();

        return response()->noContent();
    }

    /**
     * Delete temporary file
     *
     * @param Request $request
     * @return \Illuminate\Http\Response
     */
    public function revert(Request $request)
    {
        $hashName = $request->getContent();
        $temporaryUploadedFile = TemporaryUploadedFile::where('hash_name', $hashName)->firstOrFail();
        Storage::disk($temporaryUploadedFile->disk)->delete($temporaryUploadedFile->path_by_disk);
        $temporaryUploadedFile->delete();

        return response()->noContent();
    }

    /**
     * Restore temporary uploaded file
     *
     * @return \Illuminate\Http\Response
     */
    public function get(Request $request)
    {
        if ($request->has('restore')) {
            return $this->_restore($request->restore);
        } else if ($request->has('load')) {
            return $this->_load();
        }

        return response()->noContent();
    }

    /**
     * Restore temporary uploaded file
     *
     * @return void
     */
    public function _restore(String $hashName)
    {
        $temporaryUploadedFile = TemporaryUploadedFile::where('hash_name', $hashName)->firstOrFail();

        return Storage::download('temp/' . $hashName, $temporaryUploadedFile->client_original_name, [
            "Content-Disposition" => "inline",
            "filename" => $temporaryUploadedFile->client_original_name
        ]);
    }

    /**
     * Load persitent uploaded file
     *
     * @return void
     */
    public function _load()
    {
        $user = Auth::user();
        $media = $user->getMedia()
            ->sortByDesc(function ($item) {
                return $item->created_at;
            })->last();

        return response()->file($media->getPath(), [
            "Content-Disposition" => "inline",
            "filename" => $media->name
        ]);
    }
}
