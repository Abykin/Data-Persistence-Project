using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public TextMeshProUGUI menuScreen;
    public string Name;
    public string HighScoreName;
    public int HighScore;

    public void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        LoadScore();
        Debug.Log(HighScoreName);

        Instance = this;
        DontDestroyOnLoad(gameObject);

        menuScreen.text = "Best Score : " + MenuManager.Instance.HighScoreName + " : " + MenuManager.Instance.HighScore;
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();

        data.HighScoreName = Name;
        data.HighScore = HighScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            HighScoreName = data.HighScoreName;
            HighScore = data.HighScore;
        }
    }

    [System.Serializable]
    class SaveData
    {
        public string HighScoreName;
        public int HighScore;
    }
}
