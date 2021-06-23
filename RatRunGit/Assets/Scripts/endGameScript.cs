using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endGameScript : MonoBehaviour
{
    public GameObject winMenuContainer;
    public GameObject lostGameContainer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.transform.tag == "win") 
        {
            winMenuContainer.SetActive(true);
        }

        if (collide.transform.tag == "loose") 
        {
            lostGameContainer.SetActive(true);
        }

    }

    public void playAgain() 
    {
        SceneManager.LoadScene(0);
    
    }

    public void quit() 
    {
        Application.Quit();
        Debug.Log("Quiiit");
    }

}
