
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPick : MonoBehaviour
{


    public Text countText;
    public Text gameOverText;
    public int sceneNum;
   

    int count;

    void Start()
    {
        count = 0;
        SetCountText();

    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameOverText.text = "GAME OVER!";
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count == 10)
        {


            SceneManager.LoadScene(sceneNum);
            

        }

    }
}