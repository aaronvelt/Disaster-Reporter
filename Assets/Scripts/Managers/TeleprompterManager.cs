using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;
using Random = UnityEngine.Random;

public class TeleprompterManager : MonoBehaviour
{
    public static TeleprompterManager instance;
    [SerializeField]
    private Teleprompter[] teleprompters;
    [SerializeField]
    private SegmentScriptableObject[] segments;
    private int _index = 0;

    private void Awake()
    {
        instance = this;
    }
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            NextSegment();
        }
    }

    public void NextSegment()
    {
        if (_index >= segments.Length) return;
        teleprompters[Random.Range(0, teleprompters.Length)].StartSegment(segments[_index]);
        _index++;
    }
}
