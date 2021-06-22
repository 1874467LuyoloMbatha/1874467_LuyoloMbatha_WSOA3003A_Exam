using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformRotateScript : MonoBehaviour
{
    // if condition is set to false the platform will be horizontal when clicked. If condition is true platform will be vertical 
    public bool vertPlatform;

    private void OnMouseOver()
    {
        if (vertPlatform == false && Input.GetKeyDown(KeyCode.Mouse0))
        {
            this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 180f);

            vertPlatform = true;
        }
        else if (vertPlatform == true && Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            this.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90f);

            vertPlatform = false;
        }


    }
}
