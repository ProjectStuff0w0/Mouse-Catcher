using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gameElements;


    [ContextMenu("Increase Score")]

    public void Start()
    {
        gameElements.SetActive(true);

    }

    public void addScore()
    {
        score++;
        Debug.Log(scoreText);
        scoreText.text = score.ToString();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByName("SampleScene").name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);

    }
}
