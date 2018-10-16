using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextScene : MonoBehaviour
{

    public int sceneNum;
    public Text countText;
    public Text winText;
    private int count;

    private void OnGUI()
    {
       
            if (count == 20)
            {
                winText.text = "LEVEL 1 COMPLETE!";
                 GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height - 50, 100, 40), "Load Scene: " + sceneNum); 
                SceneManager.LoadScene(sceneNum);
        }

    }
}


