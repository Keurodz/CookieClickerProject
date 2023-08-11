using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Purchasing;
using UnityEngine;

public class IncrementModifier : MonoBehaviour
{
    public int incrementAmount = 1; // Amount to increment the score by
    public int price = 1; // Price of the upgrade
    public TMP_Text shopOption;
    // Update is called once per frame


    void Start()
    {
        updateText();
    }
    public void PurchasingSettings()
    {
        if (GameManager.Instance.cookieCount - price >= 0)
        {
            GameManager.Instance.cookieCount -= price;
            GameManager.Instance.cookieIncrement += incrementAmount;
            incrementAmount += Mathf.CeilToInt(incrementAmount * 0.05F);
            price += Mathf.CeilToInt(price * 0.1f);
            updateText();
        }
    }

    private void updateText()
    {
        shopOption.text = "Buy " + incrementAmount + " for " + price + " cookies";
        CookieClick.Instance.updateCookieCountText();
        CookieClick.Instance.updateCookieMultiplier();
    }
}
