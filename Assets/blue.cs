using UnityEngine;

public class StopOnFinish : MonoBehaviour
{
    private Rigidbody rb;
    private bool hasStopped = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "FinishLine" && !hasStopped)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.isKinematic = true; 
            hasStopped = true;
        }
    }
}