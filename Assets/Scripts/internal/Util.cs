using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util
{
    public static T[] AddToArray<T>(T[] target, T value)
    {
        T[] array = new T[target.Length + 1];
        for (int i = 0; i < target.Length; i++)
        {
            array[i] = target[i];
        }
        array[target.Length] = value;
        return array;
    }
}
