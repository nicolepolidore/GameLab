using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyByContact : MonoBehaviour
{

    public Text  gameOverText;
   
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Pipe")
        {
            SceneManager.LoadScene("GameOverandRestart");
           
        }
    }
}





