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

	void Start() 
    {
        liveAmount = 3; 
        sceneLoader = GameObject.FindGameObjectWithTag("Manager").GetComponent<SceneLoader>(); //definiere Sceneloader Script den ich brauche
    }
	
	void Update() 
    {
        Debug.Log("liveNumber"+liveNumber==null);
        liveNumber.text = liveAmount.ToString();
    }

    public void DecreaseLives()
    {
        liveAmount --;
        if (liveAmount == 0)
        {
            sceneLoader.SwitchToScene("GameOver");
        }
    }

    //TIMER!
}