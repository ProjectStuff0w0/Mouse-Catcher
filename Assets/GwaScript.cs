using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GwaScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int flapStrength = 10;
    public logicScript logic;
    public bool gwaAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&gwaAlive)
            rb.velocity = Vector2.up * flapStrength;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gwaAlive = false;
        logic.gameOver();
    }

    
}
