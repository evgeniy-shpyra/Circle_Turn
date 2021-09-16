using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shop1 : MonoBehaviour
{

    public Text moneyText;

    


    void Update()
    {
        moneyText.text = Money.money.ToString();
    }

    public void BuyMulti()
    {
        if (Money.money >= 20 && ManagerElement.isMulti == false)
        {
            ManagerElement.isMulti = true;
            Money.money -= 20;
            PlayerPrefs.SetInt("Money", Money.money);
        }
    }

    public void BuySpeed()
    {
        if (Money.money >= 10 && ManagerElement.isSpeed == false)
        {
            ManagerElement.isSpeed = true;
            Money.money -= 10;
            PlayerPrefs.SetInt("Money", Money.money);
        }
    }

    public void BuyMore()
    {
        if (Money.money >= 15 && ManagerElement.isMore == false)
        {
            ManagerElement.isMore = true;
            Money.money -= 15;
            PlayerPrefs.SetInt("Money", Money.money);
        }
    }


    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
