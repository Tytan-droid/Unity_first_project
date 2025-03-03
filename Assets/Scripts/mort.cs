using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mort : MonoBehaviour
{
    public Canvas gameover;
    public int hp;
    public int money;
    public int invicibility = 0;


    // Start is called before the first frame update
    void Start()
    {
        gameover = GameObject.Find("Game_over").GetComponent<Canvas>();
        gameover.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate() // tue le joueur si 0 pv et affiche les pv en haut de l'écran
    {
      if(hp == 0)
        {
            gameover.enabled = true;
            Time.timeScale = 0f;

        }
        GameObject.Find("Text_Ui_HP").GetComponent<TextMeshProUGUI>().text = "HP : " + hp;
        GameObject.Find("Text_Ui_money").GetComponent<TextMeshProUGUI>().text = "Money : " + money;
    }
}
