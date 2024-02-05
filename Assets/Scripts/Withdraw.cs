using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Withdraw : MonoBehaviour
{
    public GameObject mainWithdraw;
    public GameObject mainPayment;
    public GameObject withdraw;

    int draw1 = 10000;
    int draw3 = 30000;
    int draw5 = 50000;

    public void Withdraw1()
    {
        if (GameManager.I.customerCash >= draw1)
        {
            GameManager.I.cash += draw1;
            GameManager.I.customerCash -= draw1;
            GameManager.I.cashTxt.text = GameManager.I.cash.ToString();
            GameManager.I.customerCashTxt.text = GameManager.I.customerCash.ToString();
        }
        else
        {
            GameManager.I.NoCashPopup();
        }


    }

    public void Withdraw3()
    {
        if (GameManager.I.customerCash >= draw3)
        {
            GameManager.I.cash += draw3;
            GameManager.I.customerCash -= draw3;
            GameManager.I.cashTxt.text = GameManager.I.cash.ToString();
            GameManager.I.customerCashTxt.text = GameManager.I.customerCash.ToString();
        }
        else
        {
            GameManager.I.NoCashPopup();
        }

    }

    public void Withdraw5()
    {
        if (GameManager.I.customerCash >= draw5)
        {
            GameManager.I.cash += draw5;
            GameManager.I.customerCash -= draw5;
            GameManager.I.cashTxt.text = GameManager.I.cash.ToString();
            GameManager.I.customerCashTxt.text = GameManager.I.customerCash.ToString();
        }
        else
        {
            GameManager.I.NoCashPopup();
        }
    }


    public void ATMMain()
    {
        withdraw.SetActive(false);
        mainPayment.SetActive(true);
        mainWithdraw.SetActive(true);
    }

    void Start()
    {
        GameManager.I.cashTxt.text = GameManager.I.cash.ToString();
        GameManager.I.customerCashTxt.text = GameManager.I.customerCash.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
