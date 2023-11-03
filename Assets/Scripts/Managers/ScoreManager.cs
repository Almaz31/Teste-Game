using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    private int score;
    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void AddScore(int value)
    {
        score+=value;
    }
    public int GetScore()
    {
        return score;
    }
    public bool IsMaxScore()
    {
        return PlayerPrefs.GetInt("MaxScore", 0) < score;
    }
    public void SaveScore()
    {
        PlayerPrefs.SetInt("MaxScore", score);
    }
    public void ResetScore()
    {
        score = 0;
    }
}
