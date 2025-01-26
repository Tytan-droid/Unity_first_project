using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;

public class follow_player : MonoBehaviour
{
    public float speedennemi;

    private Rigidbody2D rb;

    private Vector2 posdprt;

    public float kbx;
    public float kby;

    // Start is called before the first frame update
    void Start() // stock la position de départ de l'ennemi
    {
        posdprt = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() // permet à l'ennemi de suivre le joueur
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

        if (GameObject.Find("joueur").GetComponent<mort>().invicibility > 0)
        {
            GameObject.Find("joueur").GetComponent<mort>().invicibility--;
        }
        if (GameObject.Find("joueur").GetComponent<mort>().invicibility < 0)
        {
            GameObject.Find("joueur").GetComponent<mort>().invicibility = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) // permet de diminuer les pv du joueur et de le faire reculer
    {
        if (collision.transform.tag == "Joueur" && collision.gameObject.GetComponent<mort>().invicibility == 0)
        {
            collision.gameObject.GetComponent<mort>().hp -= 1;
            if (collision.transform.position.x > transform.position.x)
            {
                collision.transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(kbx, kby) * Time.deltaTime);
                collision.gameObject.GetComponent<mort>().invicibility = 5;
            }
            else
            {
                collision.transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(-kbx, kby) * Time.deltaTime);
                collision.gameObject.GetComponent<mort>().invicibility = 5;
            }

        }
    }
}
