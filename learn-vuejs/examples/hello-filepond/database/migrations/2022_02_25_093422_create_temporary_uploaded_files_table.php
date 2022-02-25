<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateTemporaryUploadedFilesTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('temporary_uploaded_files', function (Blueprint $table) {
            $table->id();
            $table->string('client_original_name');
            $table->string('hash_name')->unique();
            $table->string('disk')->default('local');
            $table->string('path_by_disk');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('temporary_uploaded_files');
    }
}
