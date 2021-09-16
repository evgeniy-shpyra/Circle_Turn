using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public int money;
    public Text textMoney;

    void Start()
    {
        Money.money = PlayerPrefs.GetInt("Money");
        Money.money += Money.score;
        PlayerPrefs.SetInt("Money", Money.money);
        textMoney.text = Money.money.ToString();
        Money.score = 0;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ToShop()
    {
        SceneManager.LoadScene(3);
    }

}
