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
    private int _index;
    private int _lastPrompterIndex;

    private void Awake()
    {
        instance = this;
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            NextSegment();
        }
    }
    
    /*
     * get next segment from segments array and assign it to random teleprompter
     * if random teleprompter equals last one, get next teleprompter in array
     */
    public void NextSegment()
    {
        if (_index < segments.Length)
        {
            int randomPrompterIndex = Random.Range(0, teleprompters.Length);

            if (randomPrompterIndex == _lastPrompterIndex)
            {
                randomPrompterIndex += 1;
                if (randomPrompterIndex >= teleprompters.Length)
                {
                    randomPrompterIndex = 0;
                }
            }
            teleprompters[randomPrompterIndex].StartSegment(segments[_index]);

            _lastPrompterIndex = randomPrompterIndex;
            _index++;   
        }
    }
}
