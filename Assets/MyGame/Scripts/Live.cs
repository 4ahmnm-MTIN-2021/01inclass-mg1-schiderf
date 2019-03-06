using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live : MonoBehaviour 
{
    GameLogic gameLogic;
   
	void Start() 
    {
        gameLogic = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameLogic> () ;
		
	}
	
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("****" + col.name + " " + gameObject.tag);

        if (col.name == "Character" && gameObject.tag == "Heart" )
        {
            Debug.Log("destroyme+1");
            gameLogic.IncreaseLives();
            Destroy(this.gameObject);
        }
        else if (gameObject.tag == "Ice" && col.CompareTag("Player"))
        {
            Debug.Log("destroyme-1");
            gameLogic.DecreaseLives();
            Destroy(this.gameObject);
        }
        else if (col.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }

    }
}

// wenn dich Tomaten treffen soll man ein Leben Leben verlieren. Der Counter 
// soll von drei Leben runterzählen
//ZAHL NOCH UPDTEN!!