using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour
{
    public float speedennemi;

    private Rigidbody2D rb;

    private Vector2 posdprt;

    // Start is called before the first frame update
    void Start()
    {
        posdprt = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 posjoueur = GameObject.Find("joueur").transform.position;

        Vector3 posennemi = transform.position;

        if (Vector2.Distance(posdprt, posennemi) >= 40)
        {
            transform.position = posdprt;
        }
        if (posjoueur.x > posennemi.x)
        {
            rb.velocity = new Vector2(speedennemi, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(-speedennemi, rb.velocity.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Joueur")
        {
            collision.gameObject.GetComponent<mort>().hp -= 1;
        }
    }
}
