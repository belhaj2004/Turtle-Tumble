// Author: Colby Heist
// Contributor(s): 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ButtonInfo : MonoBehaviour
{
    public int itemID;
    public TextMeshProUGUI PriceTxt;
    public GameObject ShopManager;

    // Update is called once per frame
    void Update()
    {
        PriceTxt.text = ((float)ShopManager.GetComponent<ShopManager>().shopItems[2, itemID]).ToString();
        
    }
}

