using UnityEngine;

public class CubeSid : MonoBehaviour
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
            //_rb.isKinematic = true;
            _rb.mass= 15.0f;
            _rb.linearDamping = 5;
            _rb.angularDamping = 2f;
            _rb.useGravity= true;
        }
    }
}
