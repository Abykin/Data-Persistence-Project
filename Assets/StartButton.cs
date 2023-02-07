using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public TextMeshProUGUI nameInput;
    // Start is called before the first frame update
    public void StartGame()
    {
        MenuManager.Instance.Name = nameInput.text;
        SceneManager.LoadScene(1);
    }
}
