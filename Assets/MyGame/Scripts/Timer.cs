using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour 
{
    public GameLogic gameLogic;
    private TextMeshProUGUI watch;
    public float timer;
    private int interval = 10;

    void Start()
    {
        watch = gameObject.GetComponent<TextMeshProUGUI>();
        watch.text = "00:00:00";
    }

    void Update()
    {
        timer += Time.deltaTime;
        watch.text = string.Format("{0:00}:{1:00}.{2:00}",

            Mathf.Floor(timer / 60),
            Mathf.Floor(timer) % 60,
            Mathf.Floor((timer * 100) % 100));

        gameLogic.SetTimeTimer(watch.text);
    }
}

//Script created by Class, downloaded from GitHub