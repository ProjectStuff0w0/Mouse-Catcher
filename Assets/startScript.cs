using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startScript : MonoBehaviour
{
    public GameObject startScreen;

    // Start is called before the first frame update
    void Start()
    {
        startScreen.SetActive(true);


    }

    public void startGame()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        startScreen.SetActive(false);

    }
}
