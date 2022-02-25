<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

Route::group([
    'prefix' => 'user',
    'namespace' => 'App\Http\Controllers'
], function () {
    Route::post("/avatar", 'UserController@upload');
    Route::post("/submit", 'UserController@submit');
    Route::delete("/avatar", 'UserController@revert');
    Route::get("/avatar", 'UserController@get');
});
