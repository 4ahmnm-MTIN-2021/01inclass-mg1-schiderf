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
       if (col.name == "Character" && gameObject.tag == "Heart" )
        {
            gameLogic.IncreaseLives();
            Destroy(this.gameObject);
        }
        else if (gameObject.tag == "Ice" && col.CompareTag("Player"))
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