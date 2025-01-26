using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boutonnewgame : MonoBehaviour
{
    public Canvas menupause;
    public Canvas gameover;



    public void pressnewgame()
    {
        SceneManager.LoadScene("Jeu1");
    }
    public void pressresume()
    {
        menupause = transform.parent.GetComponent<Canvas>();
        Time.timeScale = 1f;
        menupause.enabled = false;
    }
    public void pressrestart()
    {
        gameover = transform.parent.GetComponent<Canvas>();
        SceneManager.LoadScene("Jeu1");
        Time.timeScale = 1f;
        gameover.enabled = false;
    }
}
