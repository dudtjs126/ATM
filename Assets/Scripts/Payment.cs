using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Payment : MonoBehaviour
{
    public TextMeshProUGUI cashTxt;
    public TextMeshProUGUI customerCashTxt;


    int pay1 = 10000;
    int pay3 = 30000;
    int pay5 = 50000;

    public void Payment1()
    {
        GameManager.I.cash -= pay1;
        GameManager.I.customerCash += pay1;
        cashTxt.text = GameManager.I.cash.ToString();
        customerCashTxt.text = GameManager.I.customerCash.ToString();
    }

    public void Payment3()
    {
        GameManager.I.cash -= pay3;
        GameManager.I.customerCash += pay3;
        cashTxt.text = GameManager.I.cash.ToString();
        customerCashTxt.text = GameManager.I.customerCash.ToString();
    }

    public void Payment5()
    {
        GameManager.I.cash -= pay5;
        GameManager.I.customerCash += pay5;
        cashTxt.text = GameManager.I.cash.ToString();
        customerCashTxt.text = GameManager.I.customerCash.ToString();
    }


    void Start()
    {
        cashTxt.text = GameManager.I.cash.ToString();
        customerCashTxt.text = GameManager.I.customerCash.ToString();
    }


    void Update()
    {
        
    }
}
