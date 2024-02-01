using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{


    [SerializeField] float moveSpeedMultiplier = 20f;
    private Rigidbody rb;

    // Some variables to modify the object motion
    //SerializeField enables us to eddit value in Unity
    //[SerializeField] float xValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // A method to handle movement

    void FixedUpdate() {


        // Can use method 1: Transform (buggy)
        // float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeedMultiplier;
        // float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeedMultiplier;
        // float yValue = 0f;
        
        // transform.Translate(xValue,yValue,zValue);


        // Method 2: Use force
         // Get input from the keyboard
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a movement Vector
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply the force to the Rigidbody
        rb.AddForce(movement * moveSpeedMultiplier);
    }
}
