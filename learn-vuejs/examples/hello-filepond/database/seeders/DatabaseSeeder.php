<?php

namespace Database\Seeders;

use App\Models\User;
use Carbon\Carbon;
use Illuminate\Database\Seeder;
use Illuminate\Support\Facades\Hash;

class DatabaseSeeder extends Seeder
{
    /**
     * Seed the application's database.
     *
     * @return void
     */
    public function run()
    {
        User::create([
            'name' => "Lê Đình Bình",
            'email' => "ledinhbinhit@gmail.com",
            'password' => Hash::make('#@123abc'),
            'email_verified_at' => (new Carbon())->format("Y-m-d H:i:s"),
            'remember_token' => 'jxVGTzPZ2q',
        ]);
    }
}
