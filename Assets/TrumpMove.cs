using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrumpMove : MonoBehaviour
{
	Rigidbody2D rb;
    int MoveX = 0;
    int MoveY = 0;
    public float firerate = .3f;
    float time_Since_Shot = 0f;

    public GameObject bullet;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        // get player input
        MoveX = 0;
        if (Input.GetKey("a"))
        {
            MoveX--;
        }
        if (Input.GetKey("d"))
        {
            MoveX++;
        }

        MoveY = 0;
        if (Input.GetKey("s"))
        {
            // down key does nothing
            MoveY--;
        }
        if (Input.GetKey("w"))
        {
            MoveY++;
        }
    
        if(MoveX == 0  && MoveY ==0){
            rb.velocity *= .96f;
        }
        else{
            rb.velocity = Vector2.Lerp(new Vector2(MoveX*5f ,MoveY*5f ),rb.velocity,.5f);
        }


        if (Input.GetKey("space") && time_Since_Shot >= firerate)
        {
        	Instantiate(bullet, transform.position + new Vector3(.3f,.25f,0),Quaternion.identity);
            time_Since_Shot = 0f;
        }
        time_Since_Shot += Time.deltaTime;        
        
    }
}
