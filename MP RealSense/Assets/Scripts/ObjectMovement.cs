using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 0f;
    public float newSpeed;
    public Collider proj1;
    public Collider proj2;
    public Collider proj3;
    public Collider proj4;

    SpawnProjectiles spawnProj;

    private Rigidbody rb;

    private void Start()
    {
        GameObject spawner = GameObject.FindWithTag("Spawner");
        spawnProj = spawner.GetComponent<SpawnProjectiles>();
        rb = GetComponent<Rigidbody>();
        Physics.IgnoreCollision(proj1, proj2);
        Physics.IgnoreCollision(proj1, proj3);
        Physics.IgnoreCollision(proj1, proj4);
    }

    private void Update()
    {
        newSpeed = speed * spawnProj.speedMulti;
        // Calculate the desired movement in global coordinates
        Vector3 desiredMovement = Vector3.back * newSpeed * Time.deltaTime;

        // Move the object using global coordinates
        transform.position += desiredMovement;
    }
}
