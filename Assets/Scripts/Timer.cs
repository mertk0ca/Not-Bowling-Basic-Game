using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    public Text BestTimeText;
    public float timer;
    public int timerInt;
    public int BestTime=9999;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("timerInt", BestTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timerInt = Convert.ToInt32(timer);

        TimerText.text = timerInt.ToString();

        if (BestTime > timerInt)
        {
            BestTimeText.text ="Best Time: " + PlayerPrefs.GetInt("timerInt".ToString());
            BestTime = timerInt;
        }
    }
}
