// Author: Colby Heist
// Contributor(s): 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PowerUpController : MonoBehaviour
{
    // Start is called before the first frame update
    public Image NoPower;
    public Image Attack;
    public Image Jump;
    public Image Speed;
    public GameObject InventoryManager;
    void Start()
    {
        NoPower.enabled = true;
        Attack.enabled = false;
        Jump.enabled = false;
        Speed.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        int powerUp = InventoryManager.GetComponent<InventoryManager>().selectedPowerUp;
        NoPower.enabled = (powerUp == 0);
        Attack.enabled = (powerUp == 1);
        Jump.enabled = (powerUp == 2);
        Speed.enabled = (powerUp == 3);
    }
}
