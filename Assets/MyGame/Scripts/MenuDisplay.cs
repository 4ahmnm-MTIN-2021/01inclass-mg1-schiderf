using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuDisplay : MonoBehaviour 
{
    public TextMeshProUGUI timerText;
    public TimerData data; 

	void Start() 
    {
        //timerText = GetComponent<TextMeshProUGUI>();        
        //coinText.text = PlayerPrefs.GetInt("coinAmount").ToString(); //Updated Text in der Gamover Scene
    
        timerText.text = FormatString(data.timer);
    }
    public string FormatString(float timer)
    {
        string tmp = string.Format("{0:00}:{1:00}.{2:00}",

           Mathf.Floor(timer / 60),

           Mathf.Floor(timer) % 60,

           Mathf.Floor((timer * 100) % 100));

        return tmp;
    }
}
