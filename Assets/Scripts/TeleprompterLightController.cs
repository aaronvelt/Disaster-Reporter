using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleprompterLightController : MonoBehaviour
{
    [SerializeField]
    private Material lightOn;
    [SerializeField]
    private Material lightOff;
    private Renderer rend;

    public string name;

    void Start()
    {
        rend = GetComponent<Renderer>();

        GameEvents.current.OnDialogStart += OnLightTurnOn;
        GameEvents.current.OnDialogEnd += OnLightTurnOff;
        OnLightTurnOff(name);
    }

    private void OnLightTurnOn(string name)
    {
        if (name== this.name)
        {
            rend.material = lightOn;
        }
    }

    private void OnLightTurnOff(string name)
    {
        if (name == this.name)
        {
            rend.material = lightOff;
        }
    }
}
