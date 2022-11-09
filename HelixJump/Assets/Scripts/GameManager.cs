using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    int score;

    [SerializeField]
    Text ScoreText;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameScore(int ringScore)
    {
        score += ringScore;
        ScoreText.text = score.ToString();
    }



}
