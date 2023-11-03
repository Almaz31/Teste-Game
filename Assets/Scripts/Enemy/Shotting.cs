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
        // ��������� ������� �� ������� � ������ ����� ���
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // ����������, �� ������� ����������� �� �������� ������ ��� �������
        if (distanceToPlayer < 10f && canShoot)
        {
            // ��������� ����
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);

            // �������� �������� �� ������
            Vector3 directionToPlayer = (player.position - bulletSpawn.position).normalized;

            // ����������� �������� ���
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = directionToPlayer * bulletSpeed;

            // ��������� �������� ��� ��������� �������� �������
            StartCoroutine(ShootCooldown());
            
        }
        transform.LookAt(player);
    }

    // �������� ��� ��������� �������� �������
    IEnumerator ShootCooldown()
    {
        canShoot = false;
        yield return new WaitForSeconds(1f); // ��� ���������� �� ���������
        canShoot = true;
    }
}
