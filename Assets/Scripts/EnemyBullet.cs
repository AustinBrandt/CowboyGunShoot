﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

	public float speed = 10f;
	public float duration = 3f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity =  new Vector2(speed,0);
        StartCoroutine(delete());
    }

    IEnumerator delete(){
    	yield return new WaitForSeconds(duration);
    	Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.tag == "Player"){
            UnityEngine.Debug.Log("Hit Player!");
            Destroy(gameObject);

        }
    	
    }
}
