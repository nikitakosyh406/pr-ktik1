using UnityEngine;
using UnityEngine.InputSystem;

public class RigidbodyMod : MonoBehaviour
{
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Используем Input System вместо UnityEngine.Input
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            _rb.mass = 1.0f;
            _rb.linearDamping = 0;
            _rb.angularDamping = 0.05f;
            _rb.useGravity = true;
            Debug.Log("Сброс параметров физики");
        }

        if (Keyboard.current.gKey.wasPressedThisFrame)
        {
            _rb.useGravity = !_rb.useGravity;
            Debug.Log("Use Gravity: " + _rb.useGravity);
        }

        if (Keyboard.current.kKey.wasPressedThisFrame)
        {
            _rb.isKinematic = !_rb.isKinematic;
            Debug.Log("IsKinematic: " + _rb.isKinematic);
        }

        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            _rb.AddForce(transform.forward * 5, ForceMode.Impulse);
            Debug.Log("Толчок вперёд");
        }
    }
}