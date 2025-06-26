using UnityEngine;

public class RigidbodyMod : MonoBehaviour
{
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // При нажатии Space — сбрасываем параметры тела
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.mass = 1.0f;
            _rb.drag = 0;
            _rb.angularDrag = 0.05f;
            _rb.useGravity = true;
            Debug.Log("Сброс параметров физики");
        }

        // При нажатии 'K' — делаем объект кинематическим (не реагирует на физику)
        if (Input.GetKeyDown(KeyCode.K))
        {
            _rb.isKinematic = !_rb.isKinematic;
            Debug.Log("IsKinematic: " + _rb.isKinematic);
        }

        // При нажатии 'G' — включаем/выключаем гравитацию
        if (Input.GetKeyDown(KeyCode.G))
        {
            _rb.useGravity = !_rb.useGravity;
            Debug.Log("Use Gravity: " + _rb.useGravity);
        }

        // При нажатии 'F' — придаем небольшой импульс вперёд
        if (Input.GetKeyDown(KeyCode.F))
        {
            _rb.AddForce(transform.forward * 5, ForceMode.Impulse);
            Debug.Log("Толчок вперёд");
        }
    }
}