using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHighScore();
    }

    public void UpdateHighScore()
    {
        highScoreText.text = "High Score: " + DataManager.Instance.highScoreName + 
            " - " + DataManager.Instance.highScore;
    }
}
