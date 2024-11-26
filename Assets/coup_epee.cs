using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coup_epee : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public SpriteRenderer sprite;

    public int cldown = 0;

    // Start is called before the first frame update
    void Start() // fait disparaitre l'épée au début
    {
        boxCollider = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        sprite.enabled = false;
        boxCollider.enabled = false;
    }

    private void OnTriggerStay2D(Collider2D collision) //coup d'épée si ennemie touche l'épée
    {
        if (collision.transform.tag == "ennemi" || collision.transform.tag == "Tuable_par_saut")
        {
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate() // donne un coup d'épée 
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && cldown == 0)
        { 
        cldown = (int)(1/Time.deltaTime*2/3);
        boxCollider.enabled = true;
            sprite.enabled = true;

        }
        if (cldown > 0)
        {
            cldown--;
        }

        if ( cldown < (int)(1/Time.deltaTime*1/3))
        {  
            sprite.enabled = false;
            boxCollider.enabled = false;
        }
    }
}
