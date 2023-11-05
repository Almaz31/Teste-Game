using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotting : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed = 10;
    [SerializeField] private Transform player;

    private bool canShoot = true;

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Перевіряємо, чи гравець знаходиться на достатній відстані для пострілу
        if (distanceToPlayer < 10f && canShoot)
        {
            // Отримуємо напрямок до гравця
            Vector3 directionToPlayer = (player.position - bulletSpawn.position).normalized;

            // Створюємо пулю з правильним напрямком
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.LookRotation(directionToPlayer));

            // Налаштовуємо швидкість пулі
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = directionToPlayer * bulletSpeed;

            // Запускаємо корутину для обмеження швидкості пострілу
            StartCoroutine(ShootCooldown());
        }
        transform.LookAt(player);
    }

    // Корутина для обмеження швидкості пострілу
    IEnumerator ShootCooldown()
    {
        canShoot = false;
        yield return new WaitForSeconds(1f); // Час очікування між пострілами
        canShoot = true;
    }
}
