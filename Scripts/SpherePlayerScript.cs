using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePlayerScript : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 20f;
    public float jumpForce = 150f;

    public float gravityScale = 20f;
    public static float globalGravity = -9.81f;
    
    private bool isGrounded;
    private Vector3 inertia;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {
        if (isGrounded)
        {
            inertia = CountInertia();
        }

        Move(inertia);

        AddGravity();

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    private Vector3 CountInertia()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        return new Vector3(x * speed, 0, z * speed);
    }

    private void Move(Vector3 inertia)
    {
        rb.velocity = inertia;
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void AddGravity()
    {
        Vector3 gravity = globalGravity * gravityScale * Vector3.up;
        rb.AddForce(gravity, ForceMode.Acceleration);
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }

}
