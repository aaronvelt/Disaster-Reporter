using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpotEvent : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private int _intensity;
    
    public void IncreaseShakeIntensity()
    {
        _intensity++;
        animator.SetInteger("Intensity", _intensity);
    }
}
