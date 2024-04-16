using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class middlePip : MonoBehaviour
{
    public logicScript score;
    public AudioClipPlayable audioClip;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Middle");
        score.addScore();
        
    }
}
