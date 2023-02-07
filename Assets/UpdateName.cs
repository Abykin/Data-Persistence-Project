using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UpdateName : MonoBehaviour
{
    private void Awake()
    {
        if (MenuManager.Instance.HighScore != 0)
        {
            gameObject.GetComponent<Text>().text = "Best Score: " + MenuManager.Instance.HighScoreName + " : " + MenuManager.Instance.HighScore;
        }
        else
        {
            gameObject.GetComponent<Text>().text = "Best Score: NONE";
        }
    }
}
