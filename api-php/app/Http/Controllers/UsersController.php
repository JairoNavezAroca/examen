<?php

namespace App\Http\Controllers;

use App\Models\User;
use Exception;
use Illuminate\Http\Request;

class UsersController extends Controller
{
    public function createUser(Request $request)
    {
        try {
            if (!$request->exists('name'))
                return response("Campo name no enviado", 400);
            if (!$request->exists('email'))
                return response("Campo email no enviado", 400);

            $data = User::create([
                'name' => $request->get('name'),
                'email' => $request->get('email'),
            ]);
            return response($data, 201);
        } catch (Exception $e) {
            return response("Error al registrar la data", 500);
        }
    }

    public function getUsers()
    {
        return User::get();
    }

    public function getUserById($id)
    {
        return User::where('id', $id)->get();
    }

    public function deleteUser($id)
    {
        $rowsAffected = User::where('id', $id)->delete();
        return response("Registros eliminados ". $rowsAffected, 200);
    }
}
