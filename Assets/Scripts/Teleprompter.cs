using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleprompter : MonoBehaviour
{
    [SerializeField] private string telepromterName;
    public bool playerLooked = false;
    
    void Update()
    {
        if (playerLooked)
        {
            Debug.Log( Time.time + "| I see: " + telepromterName);
            playerLooked = false;
        }
    }

    public void StartSegment(ScriptableObject segment)
    {
        
    }
}
