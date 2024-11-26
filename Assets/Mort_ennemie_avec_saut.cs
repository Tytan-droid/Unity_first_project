using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mort_ennemie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) // permet de tuer un ennemi en sautant dessus
    {
        if (collision.transform.tag == "Tuable_par_saut")
        {
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
