<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class User extends Model
{
    protected $table = 'users';
    // protected $primaryKey = 'ti_id';
    public $timestamps = false;
    protected $fillable = [
        'id',
        'name',
        'email',
        'created_at',
    ];
}
