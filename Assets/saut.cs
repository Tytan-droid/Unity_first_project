using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saut : MonoBehaviour
{

    private Rigidbody2D rb;

    private bool CanJump;

    public float jumpforce;


    // Start is called before the first frame update
    void Start()
    {
        rb = transform.parent.GetComponent<Rigidbody2D>(); ;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "sol")
        {
            CanJump = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CanJump)
        {
            rb.AddForce(new Vector2(0, jumpforce));
            CanJump = false;
        }
    }
}
