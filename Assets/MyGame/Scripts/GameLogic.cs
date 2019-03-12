using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour 
{
    private SceneLoader sceneLoader;
    public TextMeshProUGUI liveNumber;
    public int liveAmount;
    public int maxLiveAmount;//ADD TIMER HERE
    public GameObject player;
    public string timerTime;
    public Timer timer;
    public TimerData timerData;

	void Start() 
    {
        liveAmount = 3; 
        timerTime = "00:00:00";
        sceneLoader = GameObject.FindGameObjectWithTag("Manager").GetComponent<SceneLoader>(); //definiere Sceneloader Script den ich brauche
    }
	
	void Update() 
    {
//        Debug.Log("liveNumber"+liveNumber==null);
        liveNumber.text = liveAmount.ToString();
    }

    public void IncreaseLives()
    {
        liveAmount++;
        Debug.Log("liveamount: " + liveAmount);
    }

    public void DecreaseLives()
    {
        liveAmount--;
        if (liveAmount == 0)
        {
            timerData.timer = timer.timer;
            sceneLoader.SwitchToScene("GameOver");
        }
    }
    public void SetTimeTimer(string timeTimer)
    {
        Debug.Log("TimerTime");
        this.timerTime = timeTimer;
    }

}