using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_follow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //permet de fixer la caméra au joueur
    {
        transform.position=new Vector3(GameObject.Find("joueur").transform.position.x,transform.position.y,transform.position.z);
    }
}
