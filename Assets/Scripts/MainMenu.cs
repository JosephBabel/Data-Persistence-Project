using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text bestScoreText;

    void Start()
    {
        DataManager.Instance.LoadHighScore();

        string bestPlayerName = DataManager.Instance.bestPlayerName;
        int bestScore = DataManager.Instance.bestScore;

        if (bestScore != 0)
        {
            bestScoreText.text = "Best Score : " + bestPlayerName + " : " + bestScore;
        }

        Debug.Log(Application.persistentDataPath);
        Debug.Log(bestPlayerName);
    }
}
