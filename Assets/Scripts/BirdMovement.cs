using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
	public float velocity = 5f;
    public GameObject bullet;
	Rigidbody2D rb;
	float zigzagTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(velocity * -1,1f,0);
    }

    // Update is called once per frame
    void Update()
    {
        zigzagTimer += Time.deltaTime;
        if(zigzagTimer >= 1f){
        	zigzagTimer = 0;

            Instantiate(bullet, transform.position,Quaternion.identity);
        	rb.velocity = new Vector3(rb.velocity.x,-rb.velocity.y,0);
        }
    }
}
