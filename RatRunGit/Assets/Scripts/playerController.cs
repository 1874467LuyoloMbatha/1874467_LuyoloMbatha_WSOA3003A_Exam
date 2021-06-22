using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rBody;

   
   
   
    private Vector3 directionOfForce;
    private Vector2 upwardForce;

    void Start()
    {
        rBody = transform.GetComponent<Rigidbody2D>();
        directionOfForce = transform.right * speed;
        upwardForce = transform.up * speed;
       
    }

    void Update()
    {
        rBody.AddForce(directionOfForce);
    }
    

    private void OnCollisionEnter2D(Collision2D collide)
    {

        if (collide.transform.tag == "spikeTrap") 
        {
            SceneManager.LoadScene(0);
        }

        if (collide.transform.tag == "wallClimb") 
        {
            climbUp();
        }
    }

    void climbUp() 
    {
        rBody.AddForce(upwardForce);
    }
}


