
using UnityEngine;
using DG.Tweening;
public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed=1;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // ���������� �������� ����
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        // ����������� ��� �� ��'���� � ������������� DoTween
        if (movement != Vector3.zero)
        {
            Vector3 targetPosition = transform.position + movement * moveSpeed;
            transform.DOMove(targetPosition, 0.5f); // 0.5f - ���, �� ���� ���������� ���

            // ��������� ��'��� ������ �� ����
            transform.LookAt(targetPosition);
        }
    }
}
    
