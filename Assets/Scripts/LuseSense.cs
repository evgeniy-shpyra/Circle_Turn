using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LuseSense : MonoBehaviour
{

    public int score;
    public Text scoreText;

    void Start()
    {
        scoreText.text = Money.score.ToString();
    }


    public void ToRestart()
    {
        SceneManager.LoadScene(1);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }


  



}
