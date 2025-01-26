using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public Canvas menupause;
    // Start is called before the first frame update
    void Start()
    {
        menupause = GetComponent<Canvas>();
        menupause.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            menupause.enabled = true;
        }
    }
}
