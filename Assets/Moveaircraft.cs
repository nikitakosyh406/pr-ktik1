using UnityEngine;
using UnityEngine.InputSystem;

public class MoveAircraft : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5.0f;
    public float rotationSpeed = 1.0f;

    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        float forwardForce = moveInput.y * speed;
        float sideForce = moveInput.x * rotationSpeed;

        // Двигаемся вперёд относительно ориентации объекта
        rb.AddRelativeForce(Vector3.forward * forwardForce);
        // Поворачиваем по горизонтали
        rb.AddRelativeTorque(Vector3.up * sideForce);
    }
}