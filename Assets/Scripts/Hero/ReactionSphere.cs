using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionSphere : MonoBehaviour
{

    private float delayTime = 0f;
    [SerializeField]private float maxTime = 1f;
    [SerializeField,Range(0,1)] private float slowPower = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            if (delayTime <= 0f)
            {
                StartCoroutine("SlowTime");
            }
            else
            {
                delayTime = maxTime;
            }
        }
    }

    IEnumerator SlowTime()
    {
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(maxTime - delayTime);
        Time.timeScale = 1f;
        delayTime = 0f;
    }
}
