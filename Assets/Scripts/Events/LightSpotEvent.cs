using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpotEvent : MonoBehaviour
{
    [SerializeField] private Animator shakeAnimator;
    [SerializeField] private Animator flickerAnimator;
    [SerializeField] private Animator flickerMatAnimator;
    [SerializeField] private GameObject[] lights;
    private int _intensity = 0;
    
    public void IncreaseShakeIntensity()
    {
        _intensity += 1;
        shakeAnimator.SetInteger("Intensity", _intensity);
    }

    public void FlickerLight()
    {
        flickerAnimator.SetTrigger("Flicker");
        flickerMatAnimator.SetTrigger("Flicker");
    }
    public void LightOff()
    {
        if (lights == null)
        {
            Debug.Log("this shi empty");
            return;
        }
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].SetActive(false);
        }
    }
}
