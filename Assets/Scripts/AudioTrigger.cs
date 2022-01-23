using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private AudioClip clip;
    [SerializeField]
    private string objectTag = "Floor";

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == objectTag)
        {
            source.PlayOneShot(clip);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == objectTag)
        {
            source.PlayOneShot(clip);
        }
    }
}
