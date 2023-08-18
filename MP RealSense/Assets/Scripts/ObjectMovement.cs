using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float knockbackForce = 100f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Calculate the desired movement in global coordinates
        Vector3 desiredMovement = Vector3.back * speed * Time.deltaTime;

        // Move the object using global coordinates
        transform.position += desiredMovement;
    }

    public void ApplyKnockback(Vector3 force)
    {
        // Apply an external knockback force to the object
        rb.AddForce(force * knockbackForce, ForceMode.Impulse);
    }
}
