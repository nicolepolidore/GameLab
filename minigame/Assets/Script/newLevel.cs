using UnityEngine;
using UnityEngine.UI;
public class newLevel : MonoBehaviour
{
    public Text levelTwoText;
    void Start()
    {
        Invoke("DisableText", 2f);
    }

    void DisableText()
    {
        levelTwoText.enabled = false;
    }
}
