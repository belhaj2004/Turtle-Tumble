// Author: Colby Heist
// Contributor(s): 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public int turtleCoins = 0;
    public int attackBoost = 0;
    public int jumpBoost = 0;
    public int speedBoost = 0;
    public int extraLives = 0;
    public int selectedPowerUp = 0;
    public int keyCount = 0;

    public int getKeyCount()
    {
        return keyCount;
    }

    public void addCoins(int value) {
        turtleCoins += value;
    }
    public void addKey() {
        keyCount++;
    }

    public void spendCoins(int value, int itemID) {
        turtleCoins -= value;
        switch(itemID) {
            case 1:
                attackBoost ++;
                break;
            case 2:
                jumpBoost ++;
                break;
            case 3:
                speedBoost ++;
                break;
            case 4:
                extraLives ++;
                break;
            default:
                break;
        }
    }

    public void selectPowerUp(int itemID) {
        if (getPowerUp(itemID) > 0) {
            selectedPowerUp = itemID;
        }
    }

    public int usePowerUp() {
        switch(selectedPowerUp) {
            case 1:
                attackBoost--;
                selectedPowerUp = attackBoost == 0 ? 0 : 1;
                return 1;
            case 2:
                jumpBoost--;
                selectedPowerUp = attackBoost == 0 ? 0 : 2;
                return 2;
            case 3:
                speedBoost--;
                selectedPowerUp = attackBoost == 0 ? 0 : 3;
                return 3;
            default:
                return 0;
        }
    }

    public int getPowerUp(int itemID) {
        switch(itemID) {
            case 1:
                return attackBoost;
            case 2:
                return jumpBoost;
            case 3:
                return speedBoost;
            case 4:
                return extraLives;
            default:
                return 0;
        }
    }

    
    public void useExtraLife() {
        extraLives--;
    }
}
