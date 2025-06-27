using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollControl : MohoBehaviour
{
    public Animator animator;
    public Rigidbody[] allRigidbodies;

    private void Awake()
    {
        for (int i = 0; i < allRigidbodies.Lenght; i++)
        {
            allRigidbodies[i].isKinematic = true;
        }
    }

    void update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MakePhysics();
        }
    }
    public void MakePhysics()
    {
        animator.enabled = false;
        for (int i = 0; i < allRigidbodies.Lenght; i++)
        {
            allRigidbodies[i].isKinematic = false;
        }
    }
}