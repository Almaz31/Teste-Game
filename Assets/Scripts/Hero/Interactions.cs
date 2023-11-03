using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MoonCoin"))
        {
            Destroy(other.gameObject);
            CoinManager.Instance.AddCoin();
            Debug.Log("Pick Coin");
        }
    }
}
