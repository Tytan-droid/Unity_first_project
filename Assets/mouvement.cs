using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{

    public float speed;

    private Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            flip(rb.velocity.x);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            flip(rb.velocity.x);
        }
        else 
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }
    void flip(float vx)
    {
        if((vx>0 && transform.localScale.x < 0) || (vx<0 && transform.localScale.x > 0))
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

    }
}
