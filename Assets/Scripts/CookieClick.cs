using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CookieClick : MonoBehaviour
{
    public static CookieClick Instance;
    public TMP_Text cookieDisplay;
    public TMP_Text cookieMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        updateCookieCountText();
        updateCookieMultiplier();
    }

    // Update is called once per frame
    public void OnClick()
    {
        GameManager.Instance.cookieCount += GameManager.Instance.cookieIncrement;
        updateCookieCountText();
    }

    public void updateCookieCountText()
    {
        cookieDisplay.text = "Cookies : " + GameManager.Instance.cookieCount;
    }

    public void updateCookieMultiplier()
    {
        cookieMultiplier.text = "Cookie Multiplier : " + GameManager.Instance.cookieIncrement;
    }
}
