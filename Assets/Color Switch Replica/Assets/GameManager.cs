using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0000;
    public int highScore = 0;
    public GameObject GameOverCanvas;
    public Text scoreText;
    public Text highscoretext;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "S:" + score;
        highscoretext.text = "HS:" + highScore;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score = score + 1;
        scoreText.text = "S:" + score;

        int highScore = PlayerPrefs.GetInt("HIGHSCORE");
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HIGHSCORE", score);

            highscoretext.text = "HS:" + score;
        }
        else
        {
            highscoretext.text = "HS:" + highScore;
        }



    }
    public void GameOver()
    {
        
        GameOverCanvas.SetActive(true);
        

        Time.timeScale = 0;


    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
