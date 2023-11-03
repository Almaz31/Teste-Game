
using UnityEngine;
using DG.Tweening;
public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed=1;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Отримуємо введення від клавіатури
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Обчислюємо напрямок руху
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        // Застосовуємо рух до об'єкта з використанням DoTween
        if (movement != Vector3.zero)
        {
            Vector3 targetPosition = transform.position + movement * moveSpeed;
            transform.DOMove(targetPosition, 0.5f); // 0.5f - час, за який відбудеться рух
        }
    }
}
