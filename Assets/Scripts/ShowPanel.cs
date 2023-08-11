using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanel : MonoBehaviour
{
    public GameObject upgradePanel; // Reference to the upgrade panel GameObject

    public void ToggleUpgradePanel()
    {
        upgradePanel.SetActive(!upgradePanel.activeSelf);
    }
}
