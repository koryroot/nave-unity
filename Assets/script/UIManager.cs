using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
   
    int score = 0;

    [SerializeField] TextMeshProUGUI scoreText;
    public int scoret;

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        scoret = int.Parse(scoreText.text);
    }
    public void AddScore10()
    {
        score = score + 10;
        scoreText.text = score.ToString();
        scoret = int.Parse(scoreText.text);
    }

}
