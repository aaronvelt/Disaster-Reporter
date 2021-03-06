using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform cameraTransform;
    
    void Update()
    {
        FireRaycast(cameraTransform);
    }
    
    /* fire raycast and check for object with teleprompter component
     * set teleprompter's playerLooked to true.
     */
    void FireRaycast(Transform start, float range = 50f)
    {
        RaycastHit hit;

        if (Physics.Raycast(start.position, start.forward, out hit, range))
        {
            Teleprompter target = hit.collider.GetComponent<Teleprompter>();

            if (target != null)
            {
                target.playerLooked = true;
            }
        }
    }
}
