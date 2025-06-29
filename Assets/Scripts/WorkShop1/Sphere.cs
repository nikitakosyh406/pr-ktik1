using UnityEngine;

public class Sphere : MonoBehaviour
{
    private Rigidbody _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            _rb.isKinematic = false;
            _rb.mass= 50.0f;
            _rb.linearDamping = 12;
            _rb.angularDamping = 9f;
            //_rb.useGravity= true;
        }
    }
}
