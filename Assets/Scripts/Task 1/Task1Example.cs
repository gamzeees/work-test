using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The 'Singleton' class
/// </summary>
public class Task1Example
{
    // Singleton for Task1Example
    public static Task1Example instance
    {
        get
        {
            if (_instance == null)
                _instance = new Task1Example();
            return _instance;
        }
    }
    private static Task1Example _instance = null;

    /// <summary>
    /// This method will be called when any specified key is pressed down
    /// </summary>
    public void OnKeyDown()
    {
        Debug.Log("Singleton is being called");
    }
}
