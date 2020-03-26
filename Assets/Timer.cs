using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject GameOver;
    public Text timeDisplay;
    int hour, minute, second;
    float basetime;
    // Start is called before the first frame update
    void Start()
    {
        hour = 23;
        minute = 50;
        second = 0;
        basetime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        second = (int)((Time.time - basetime) % 60);
        minute = 50 + (int)((Time.time - basetime) / 60);
        if (minute > 59)
        {
            hour += 1;
            minute = 0;
            GameOver.SetActive(true);
        }
        timeDisplay.text = hour.ToString("D2") + ':' + minute.ToString("D2") + ':' + second.ToString("D2");
    }
}
