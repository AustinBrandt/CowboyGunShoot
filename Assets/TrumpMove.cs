using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrumpMove : MonoBehaviour
{
	Rigidbody2D rb;
    int MoveX = 0;
    int MoveY = 0;
    
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
            rb.velocity *= .95f;
        }
        else{
            rb.velocity = Vector2.Lerp(new Vector2(MoveX*4f ,MoveY*4f ),rb.velocity,.5f);
        }

        
        
    }
}
