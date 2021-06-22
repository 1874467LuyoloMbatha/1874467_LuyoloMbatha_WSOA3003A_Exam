using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickDestroy : MonoBehaviour
{
    public float betweenClicks = 1f;
    public float startingTime;


    public int numberOfClicks = 0;
   
    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            startingTime = Time.time;

            if ((Time.time - startingTime) < betweenClicks)
            {
                numberOfClicks++;
                if (numberOfClicks == 3)
                {
                    breakWall();
                }
            }

            else
            {
                numberOfClicks = 0;
            }
        }
    }
    void breakWall()
    {
        Destroy(gameObject);
    }

}

