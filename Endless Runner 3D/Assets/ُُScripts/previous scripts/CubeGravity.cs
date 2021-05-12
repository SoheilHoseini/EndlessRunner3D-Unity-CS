using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGravity : MonoBehaviour
{
    public new Rigidbody rigidbody;//to control the gravity by pushing 'space' button

    private GameObject gb;//to control an object with another object's component
    public Rigidbody rb;

    // Start is called before the first frame update to initialize fields
    void Start()
    {

        rb = gb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Space))
        {
            //rigidbody.useGravity = true;
            rb.useGravity = true;
        }

        if (Input.GetKeyUp(KeyCode.X))
        {
            rigidbody.useGravity = true;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
    }
}
