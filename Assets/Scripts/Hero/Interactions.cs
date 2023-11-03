using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    [SerializeField] private int scoreForKill=10;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MoonCoin"))
        {
            Destroy(other.gameObject);
            CoinManager.Instance.AddCoin();
            Debug.Log("Pick Coin");
        }
        else if (other.CompareTag("Bullet"))
        {
            GameManager.Instance.Lose();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            ScoreManager.Instance.AddScore(scoreForKill);
        }
    }
}
