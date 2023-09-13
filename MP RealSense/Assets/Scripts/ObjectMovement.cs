using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 0f;
    public float speedMulti = 1.0f;
    public float newSpeed;
    public float scalingInterval = 30.0f;

    private WaitForSeconds waitInterval;

    private Rigidbody rb;

    private void Start()
    {
        speedMulti = 1.0f;
        StartCoroutine(IntervalAction());
        waitInterval = new WaitForSeconds(scalingInterval);
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Calculate the desired movement in global coordinates
        Vector3 desiredMovement = Vector3.back * speed * Time.deltaTime;

        // Move the object using global coordinates
        transform.position += desiredMovement;
        Debug.Log(speedMulti + " AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
    }

    public IEnumerator IntervalAction()
    {
        while (true)
        {
            Time.timeScale += 0.1f;
            newSpeed = speed * speedMulti;
            Debug.Log(newSpeed + " BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB");
            // Wait for the specified interval before running the code again
            yield return waitInterval;
        }
    }
}
