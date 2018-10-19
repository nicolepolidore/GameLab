using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public Text scoreText;
        private int score;
    

     void Start()
    {
        score = 0;
        SetScoreText();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("county"))
        {
            score = score + 1;
            SetScoreText();
            
            
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score:" + score.ToString();


    }
}
