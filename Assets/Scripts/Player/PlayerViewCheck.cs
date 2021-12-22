using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerViewCheck : MonoBehaviour
{
    void FireRaycast(Transform start)
    {
        RaycastHit hit;

        if (Physics.Raycast(start.position, start.forward, out hit))
        {
            Teleprompter target = hit.collider.GetComponent<Teleprompter>();

            if (target != null && target.GetComponent<Teleprompter>() != null)
            {
                
            }
        }
    }
}
