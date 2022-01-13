using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    void Awake()
    {
        current = this;
    }

    public event Action<string> OnDialogStart;
    public void DialogStart(string name)
    {
        if (OnDialogStart != null)
        {
            OnDialogStart(name);
        }
    }

    public event Action<string> OnDialogEnd;
    public void DialogEnd(string name)
    {
        if (OnDialogEnd != null)
        {
            OnDialogEnd(name);
        }
    }

}
