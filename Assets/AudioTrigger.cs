using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private AudioClip clip;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Floor")
        {
            source.PlayOneShot(clip);
        }
    }
}
