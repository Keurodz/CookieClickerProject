using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoClicker : MonoBehaviour
{
    public Button cookieButton; // Reference to the cookie button
    public float clickInterval = 1.0f; // Time between auto clicks

    private void Start()
    {
        // Start the auto clicker
        StartCoroutine(AutoClickCoroutine());
    }

    private IEnumerator AutoClickCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(clickInterval);
            ClickCookie();
        }
    }

    private void ClickCookie()
    {
        // Simulate a click on the cookie button
        cookieButton.onClick.Invoke();
    }
}
