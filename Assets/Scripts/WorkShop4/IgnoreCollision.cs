using System;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    public Collider collider1;
    public Collider collider2;

    private void Start()
    {
        Physics.IgnoreCollision(collider1, collider2);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider == collider1)
        {
            collider1.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
