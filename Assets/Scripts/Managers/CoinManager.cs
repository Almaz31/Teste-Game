using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;

    private int numOfCoins;
    private void Awake()
    {
        if(Instance == null)Instance = this;
    }
    public void AddCoin()
    {
        numOfCoins++;
        Debug.Log(numOfCoins);
    }
    public void SaveCoins()
    {
        PlayerPrefs.SetInt("MoonCoin", PlayerPrefs.GetInt("MoonCoin", 0)+numOfCoins);
    }
    public int SpendCoins(int amount)
    {   if (PlayerPrefs.GetInt("MoonCoin", 0) > amount)
        {
            PlayerPrefs.SetInt("MoonCoin", PlayerPrefs.GetInt("MoonCoin") - amount);
            return 1;
        }
        else return -1;
    }
}
