using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisFall : MonoBehaviour
{
    [SerializeField] private Animator animator;
    
    public void Fall()
    {
        animator.SetTrigger("Fall");
    }
}
