using UnityEngine;

public class Moveaircraft : MonoBehaviour
{
    private Rigidbody Rigidbodyrb;
    public float Speed = 5.0f; // Aircraft speed
    public float RotationSpeed = 1.0f; // Aircraft rotation speed
    public float jumpForce = 1.0f;
    public float hoverHeight = 2.0f;

    void Start()
    {
        Rigidbodyrb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float sideForce = Input.GetAxis("Horizontal") * RotationSpeed;
        float forwardForce = Input.GetAxis("Vertical") * Speed;

        Rigidbodyrb.AddRelativeForce(0f, 0f, -forwardForce);
        Rigidbodyrb.AddRelativeTorque(0f, sideForce, 0f);
        
        float distanceToGround = hoverHeight;
        if (Physics.Raycast(transform.position, -Vector3.up, out RaycastHit hit, hoverHeight))
        {
            distanceToGround = hit.distance;
        }

        float verticalVelocity = Rigidbodyrb.linearVelocity.y;


        float adjustment = Mathf.Clamp((hoverHeight - distanceToGround) * 0.3f, 0, 1) * jumpForce;
        Rigidbodyrb.AddRelativeForce(Vector3.up * adjustment, ForceMode.Impulse);
        
    }

}
