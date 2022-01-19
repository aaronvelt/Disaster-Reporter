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
        Debug.Log(other.gameObject.tag + " Trigger Hit!");

        if (other.gameObject.tag == objectTag)
        {
            source.PlayOneShot(clip);
            Debug.Log(other.gameObject.tag + " Trigger Hit!");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag + " Collision Hit!");

        if (collision.collider.tag == objectTag)
        {
            source.PlayOneShot(clip);
            Debug.Log(collision.collider.tag + " Collision Hit!");
        }
    }
}
