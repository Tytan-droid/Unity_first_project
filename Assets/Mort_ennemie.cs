using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mort_ennemie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.transform.name);
        if (collision.transform.tag == "Ennemi")
        {
            Debug.Log("dedans");
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
