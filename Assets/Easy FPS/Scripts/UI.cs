using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public int Score = 0;
    public bool Gameover = false;

    public Text Scoretext;
    public GameObject Dead;
    public GameObject score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Gameover==false)
        {
            Scoretext.text = "Score : " + (int)Score;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("_scene");
            }

        }
        
    }
}
