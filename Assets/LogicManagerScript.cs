using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public PipeMoveScript pipe;
    public GameObject GameOverScreen;
    public GameObject WingUp;
    public GameObject WingDown;
    public int playerScore = 0;
    public Text scoreText;
    public float moveSpeed = 5;
    public float speedModifier = 1.05f;
    public float increaseSpeedInterval = 10;
    private float timerSpeed = 0;

    [ContextMenu("addScore")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    [ContextMenu("increaseSpeed")]
    public void increaseSpeed()
    {
        if (timerSpeed < increaseSpeedInterval)
        {
            timerSpeed += Time.deltaTime;
        }
        else
        {
            moveSpeed *= speedModifier;
            timerSpeed = 0;
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }

    public void wingAnimation()
    {
        WingUp.SetActive(!WingUp.activeSelf);
        WingDown.SetActive(!WingDown.activeSelf);
    }
}
