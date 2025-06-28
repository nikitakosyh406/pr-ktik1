using UnityEngine;

public class BounceOnFinish : MonoBehaviour
{
    private Collider myCollider;

    void Start()
    {
        myCollider = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "FinishLine")
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                
                rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            }
        }
    }
}