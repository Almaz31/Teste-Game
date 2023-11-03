using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour
{
    private float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 10f)
        {
            Destroy(gameObject);
        }
    }
}
