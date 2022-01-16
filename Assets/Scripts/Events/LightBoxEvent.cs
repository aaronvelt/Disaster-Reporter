using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBoxEvent : MonoBehaviour
{
    [SerializeField] private MeshRenderer lightMesh;
    [SerializeField] private Material lightOffMaterial;
    [SerializeField] private Animator animator;
    
    public void Fall()
    {
        Debug.Log("Fall " + name );
        lightMesh.material = lightOffMaterial;
        animator.SetTrigger("fall");
    }
}
