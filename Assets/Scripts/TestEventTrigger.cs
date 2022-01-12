using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEventTrigger : MonoBehaviour
{
    public string name;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            InputTestTriggerOn();
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            InputTestTriggerOff();
        }
    }

    public void InputTestTriggerOn()
    {
        GameEvents.current.DialogStart(name);

    }
    public void InputTestTriggerOff()
    {
        GameEvents.current.DialogEnd(name);

    }
}
