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

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.DOMove(targetPosition, 0.1f * followSpeed); // Застосовуємо рух камери з плавним переходом
    }
}
