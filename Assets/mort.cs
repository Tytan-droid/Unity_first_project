using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class mort : MonoBehaviour
{

    public int hp;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      if(hp == 0)
        {
            Destroy(gameObject);


        }
        GameObject.Find("Text_Ui_HP").GetComponent<TextMeshProUGUI>().text = "HP : " + hp;
    }
}
