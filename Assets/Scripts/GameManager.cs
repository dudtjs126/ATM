using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager I;
    public GameObject mainPayment;
    public GameObject payment;
    public GameObject mainWithdraw;
    public GameObject withdraw;
    public int cash = 100000;
    public int customerCash = 50000;
    public TextMeshProUGUI cashTxt;
    public TextMeshProUGUI customerCashTxt;
    public GameObject popup;

    private void Awake()
    {
        I = this;
    }


    public void Payment()
    {
        mainPayment.SetActive(false);
        mainWithdraw.SetActive(false);
        payment.SetActive(true);
    }

    public void Withdraw()
    {
        mainPayment.SetActive(false);
        mainWithdraw.SetActive(false);
        withdraw.SetActive(true);
    }

    public void NoCashPopup()
    {
        popup.SetActive(true);
    }

    public void NoCashBtn()
    {
        popup.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {
        cashTxt.text = cash.ToString();
        customerCashTxt.text = customerCash.ToString();
    }




    // Update is called once per frame
    void Update()
    {

    }
}
