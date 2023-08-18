using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 5.0f;

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
}
