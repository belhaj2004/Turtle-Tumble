// Author: Colby Heist
// Contributor(s): 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;


public class ShopManager : MonoBehaviour
{
    public int[,] shopItems = new int[4,5];
    public int turtleCoins;
    public TextMeshProUGUI[] CoinTxt = new TextMeshProUGUI[2] ;
    public TextMeshProUGUI KeyTxt;
    public GameObject InventoryManager;

    void Start() {
        turtleCoins = InventoryManager.GetComponent<InventoryManager>().turtleCoins;
        UpdateCoinText();
        UpdateKeyText();
        //Item IDs
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        //Item Prices
        shopItems[2, 1] = 3;
        shopItems[2, 2] = 2;
        shopItems[2, 3] = 2;
        shopItems[2, 4] = 5;

    }

    public void Buy(int itemID) 
    {
        int price = shopItems[2, itemID];
        if (turtleCoins >= price) {
            InventoryManager.GetComponent<InventoryManager>().spendCoins(price, itemID);
            turtleCoins = InventoryManager.GetComponent<InventoryManager>().turtleCoins;
        }
    }
    void UpdateCoinText() {
        turtleCoins = InventoryManager.GetComponent<InventoryManager>().turtleCoins;
        string turtleCoinString = ((float)turtleCoins).ToString();
        switch(turtleCoinString.Length) {
            case 3:
                CoinTxt[0].text = CoinTxt[1].text = turtleCoinString;
                break;
            case 2:
                CoinTxt[0].text = CoinTxt[1].text = "0" + turtleCoinString;
                break;
            case 1:
                CoinTxt[0].text = CoinTxt[1].text = "00" + turtleCoinString;
                break;
            default:
                break;
        }
    }
    void UpdateKeyText() {
        string keyCount = ((float)InventoryManager.GetComponent<InventoryManager>().keyCount).ToString();
        KeyTxt.text = keyCount; 
    }
    // Update is called once per frame
    void Update()
    {
        UpdateCoinText();
        UpdateKeyText();
    }
}
