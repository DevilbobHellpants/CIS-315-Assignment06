/*
 * (Noah Trillizio)
 * (Assignment 6)
 * (Controls the Singletions)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    public static T instance;

    public static T Instance
    {
        get { return instance; }
    }

    public static bool IsIntialized
    {
        get { return instance != null; }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("[Singleton] Trying to instanciate a" + 
                " second instance of a singleton class");
        }
        else
        {
            instance = (T)this;
        }
    }

    protected virtual void OnDestory()
    {
        //if this object is destoryed, make instance null so another can be created
        if (instance == null)
        {
            instance = null;
        }
    }
}
