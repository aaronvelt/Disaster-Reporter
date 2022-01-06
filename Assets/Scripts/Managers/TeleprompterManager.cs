using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

public class TeleprompterManager : MonoBehaviour
{
    [SerializeField]
    private Teleprompter[] teleprompters;
    [SerializeField]
    private SegmentScriptableObject[] segments;

    private int _index = 0;

    public void NextSegment()
    {
        if (_index >= segments.Length) return;
        teleprompters[Random.Range(0, teleprompters.Length)].StartSegment(segments[_index]);
        _index++;
    }
}
