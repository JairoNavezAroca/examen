<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\UsersController;

Route::post('/users', [UsersController::class, 'createUser']);
Route::get('/users', [UsersController::class, 'getUsers']);
Route::get('/users/{id}', [UsersController::class, 'getUserById']);
Route::delete('/users/{id}', [UsersController::class, 'deleteUser']);
