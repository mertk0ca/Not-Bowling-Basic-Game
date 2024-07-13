using JetBrains.Annotations;
//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBall : MonoBehaviour
{
    public GameObject[] balls;
    public float spawnTime = 1f;
    public int spawnCount = 0;

    public Text CountText;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBallFunc", spawnTime, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        CountText.text = spawnCount.ToString();
    }

    void SpawnBallFunc()
    {
        int randomIndex = Random.Range(0, balls.Length);
        Instantiate(balls[randomIndex],transform.position,transform.rotation);
        spawnCount++;
    }

}
