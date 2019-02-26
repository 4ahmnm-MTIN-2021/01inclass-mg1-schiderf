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
        Debug.Log(col.tag);
        if (gameObject.name == "ice" && col.CompareTag("Player"))
        {
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