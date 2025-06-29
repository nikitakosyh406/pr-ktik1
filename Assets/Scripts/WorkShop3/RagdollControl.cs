using System;
using UnityEngine;

public class RagdollControl : MonoBehaviour
{

    public Animator animator;
    public Rigidbody[] allRigitbodies;

    private void Awake()
    {
        for (var i = 0; i < allRigitbodies.Length; i++)
        {
            allRigitbodies[i].isKinematic = true;
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MakePhysics();
        }
    }

    private void MakePhysics()
    {
        animator.enabled = false;
        for (var i = 0; i < allRigitbodies.Length; i++)
        {
            allRigitbodies[i].isKinematic = false;
        }
    }
}
