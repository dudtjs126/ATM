using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Payment : MonoBehaviour
{
    public GameObject mainWithdraw;
    public GameObject mainPayment;
    public GameObject payment;

    int pay1 = 10000;
    int pay3 = 30000;
    int pay5 = 50000;

    public void Payment1()
    {
        if (GameManager.I.cash >= pay1)
        {
            GameManager.I.cash -= pay1;
            GameManager.I.customerCash += pay1;
            GameManager.I.cashTxt.text = GameManager.I.cash.ToString();
            GameManager.I.customerCashTxt.text = GameManager.I.customerCash.ToString();
        }
        else
        {
            Debug.Log("ÀÜ¾× ºÎÁ·");
        }


    }

    public void Payment3()
    {
       if (GameManager.I.cash >= pay3)
        {
            GameManager.I.cash -= pay3;
            GameManager.I.customerCash += pay3;
            GameManager.I.cashTxt.text = GameManager.I.cash.ToString();
            GameManager.I.customerCashTxt.text = GameManager.I.customerCash.ToString();
        }
       else
        {

        }
        
    }

    public void Payment5()
    {
        if (GameManager.I.cash >= pay5)
        {
            GameManager.I.cash -= pay5;
            GameManager.I.customerCash += pay5;
            GameManager.I.cashTxt.text = GameManager.I.cash.ToString();
            GameManager.I.customerCashTxt.text = GameManager.I.customerCash.ToString();
        }
        else
        {

        }
    }


    public void ATMMain()
    {
        payment.SetActive(false);
        mainPayment.SetActive(true);
        mainWithdraw.SetActive(true);
    }

    void Start()
    {
        GameManager.I.cashTxt.text = GameManager.I.cash.ToString();
        GameManager.I.customerCashTxt.text = GameManager.I.customerCash.ToString();
    }


    void Update()
    {
        
    }
}
