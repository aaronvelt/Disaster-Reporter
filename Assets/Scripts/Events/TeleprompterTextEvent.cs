using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleprompterTextEvent : MonoBehaviour
{
    public Teleprompter[] teleprompters;
    [SerializeField] private float textIncreasedSpeed;
    [SerializeField] private int textIncreasedSize;
    
    public void IncreaseTextSpeed()
    {
        foreach (Teleprompter teleprompter in teleprompters)
        {
            teleprompter.textSpeed = textIncreasedSpeed;
        }
    }

    public void IncreaseFontSize()
    {
        foreach (Teleprompter teleprompter in teleprompters)
        {
            teleprompter.textContent.fontSize = textIncreasedSize;
        }
    }
}
