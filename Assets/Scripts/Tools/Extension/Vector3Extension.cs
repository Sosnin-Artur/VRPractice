﻿using UnityEngine;

public static class Vector3Extension
{

    public static Vector3 SetX(this Vector3 vector, float value)
    {        
        return new Vector3(value, vector.y, vector.z);
    }

    public static Vector3 SetY(this Vector3 vector, float value)
    {
        return new Vector3(vector.x, value, vector.z);
    }

    public static Vector3 SetZ(this Vector3 vector, float value)
    {
        return new Vector3(vector.x, vector.y, value);
    }
}

