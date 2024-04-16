using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class pipspawn : MonoBehaviour
{
    public GameObject pip;
    public float spawnRate = 2;
    private float timer = 0;
    private float hOffset = 2;
    // Start is called before the first frame update
    void Start()
    {
        spawnpip();

    }


    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate)
         timer += Time.deltaTime;
        else
        {
            timer = 0;
            spawnpip();
        }
    }

    void spawnpip()
    {
        float high = transform.position.y + hOffset;
        float low = transform.position.y - hOffset;
        Instantiate(pip,new Vector3(transform.position.x,Random.Range(low,high),0), transform.rotation);

    }
}
