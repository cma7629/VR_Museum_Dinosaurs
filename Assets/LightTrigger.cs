using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public Light targetLight;




    private void OnTriggerEnter(Collider other)
    {
      
        if (other.CompareTag("Player"))
        {
            if (targetLight != null)
            {
                targetLight.enabled = true; 
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (targetLight != null)
            {
                targetLight.enabled = false; 
            }
        }
    }
}
