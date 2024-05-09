// Author: Colby Heist
// Contributor(s): 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryInfo : MonoBehaviour
{
    public int itemID;
    public TextMeshProUGUI QuantityTxt;
    public GameObject InventoryManager;
    // Start is called before the first frame update
    void Update()
    {
        QuantityTxt.text = ((float)InventoryManager.GetComponent<InventoryManager>().getPowerUp(itemID)).ToString();

        
    }
}
