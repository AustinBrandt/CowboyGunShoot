using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    Collider2D hurtbox;
    bool invuln = false;

    int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    void OnTriggerEnter2D(Collider2D col){

        UnityEngine.Debug.Log("Hit");

        if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "EnemyBullet" && !invuln)
        {
            health--;
            UnityEngine.Debug.Log("OUCH!");
            if(health <= 0){
                UnityEngine.Debug.Log("DEAD!");
            }
        }
    }
}
