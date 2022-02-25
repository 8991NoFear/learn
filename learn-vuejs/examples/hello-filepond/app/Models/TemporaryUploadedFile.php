<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class TemporaryUploadedFile extends Model
{
    protected $table = 'temporary_uploaded_files';
    protected $guarded = ['id'];
}
