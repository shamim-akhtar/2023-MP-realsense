using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestTarget : MonoBehaviour
{
    public SpawnObjects spawnObjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ClickTarget();
    }

    void ClickTarget()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0)) // 0 corresponds to the left mouse button
        {
            // Cast a ray from the mouse position into the scene
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits the GameObject attached to this script
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // If the click hits the GameObject, destroy it
                Destroy(gameObject);
                spawnObjects.numberTargets -= 1f;

                spawnObjects.score += 10;
                spawnObjects.uiText.text = "Score: " + spawnObjects.score;
            }
        }
    }
}
