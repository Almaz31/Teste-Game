using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using DG.Tweening;
using System.Runtime.InteropServices;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;

    [SerializeField] private float followSpeed = 1f;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float damping = 1;

    private void Start()
    {
    }

    private void LateUpdate()
    {
        float currentAngle = transform.eulerAngles.y;
        float desiredAngle = target.transform.eulerAngles.y;
        float angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime * damping);

        Quaternion rotation = Quaternion.Euler(0, angle, 0);
        transform.position = target.transform.position - (rotation * offset);

    }
}
