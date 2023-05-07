using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int player1Score;
    public int player2Score;
    public Text score1Text;
    public Text score2Text;
    public GameObject gameOverScreenP1;
    public GameObject gameOverScreenP2;
    public BallScript ball;
    public PlayerScript player;
    public PlayerScript player2;
    public PlayerScript AIplayer;
    private Scene currentScene;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "SampleScene - AIplayer")
        {
            AIplayer = GameObject.FindGameObjectWithTag("AIPlayer").GetComponent<PlayerScript>();
        }
        else if (currentScene.name == "SampleScene")
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        }
        player2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<PlayerScript>();
        
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallScript>();     
    }

    [ContextMenu("Increase P1 Score")]
    public void addPlayer1Score()
    {
        player1Score++;
        reset();
        if (player1Score == 5)
        {
            p1Wins();
        }
        score1Text.text = player1Score.ToString();
    }

    [ContextMenu("Increase P2 Score")]
    public void addPlayer2Score()
    {
        player2Score++;
        reset();
        if (player2Score == 5)
        {
            p2Wins();
        }
        score2Text.text = player2Score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    [ContextMenu("Reset")]
    public void reset()
    {
        ball.resetPosition();
        if (currentScene.name == "SampleScene - AIplayer")
        {
            AIplayer.resetPosition();
        }
        else if (currentScene.name == "SampleScene")
        {
            player.resetPosition();
        }
        player2.resetPosition();
    }

    public void p1Wins()
    {
        gameOverScreenP1.SetActive(true);
        Time.timeScale = 0f;
    }

    public void p2Wins()
    {
        gameOverScreenP2.SetActive(true);
        Time.timeScale = 0f;
    }
}
