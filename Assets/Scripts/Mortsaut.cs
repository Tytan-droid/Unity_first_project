using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mort_ennemie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) // permet de tuer un ennemi en sautant dessus
    {
        Debug.Log(collision.gameObject.GetComponent<mort>());
        if ((collision.transform.tag == "Tuable_par_saut" || collision.transform.tag == "Tuable_par_saut_et_épée") && collision.gameObject.GetComponentInParent<mort>())
        {
            Debug.Log("dessus");
            if(collision.gameObject.GetComponent<mort>().invicibility == 0)
            {
                Destroy(collision.gameObject);
            }
           
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
