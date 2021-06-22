using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanCOntrollerScript : MonoBehaviour
{
    bool fanIsOn;

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && fanIsOn == false)
        {
            GetComponent<AreaEffector2D>().enabled = true;
            GetComponent<ParticleSystem>().enableEmission = true; // Not sure of the "emission.enabled" syntax.
            fanIsOn = true;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && fanIsOn == true)
        {
            GetComponent<AreaEffector2D>().enabled = false;
            GetComponent<ParticleSystem>().enableEmission = false;
            fanIsOn = false;

        }
    }  
}
