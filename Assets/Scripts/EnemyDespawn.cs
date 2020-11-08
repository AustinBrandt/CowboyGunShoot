using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDespawn : MonoBehaviour
{

	public int health = 1;

	void OnTriggerEnter2D(Collider2D col)
	{

		if(col.gameObject.tag == "PlayerBullet"){
			health--;
			if(health == 0)Destroy(gameObject);
    	}
	}

    void OnTriggerExit2D(Collider2D col){

    	if(col.gameObject.tag == "DespawnWall"){
    		Destroy(gameObject);
    	}

    }
}
