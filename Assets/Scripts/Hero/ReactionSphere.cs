using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionSphere : MonoBehaviour
{

    private float delayTime = 0f;

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
                delayTime = 1f;
            }
        }
    }

    IEnumerator SlowTime()
    {
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(1f - delayTime);
        Time.timeScale = 1f;
        delayTime = 0f;
    }
}
