using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    Rigidbody rigi;
    Vector3 mySpeed;
    bool spinny = false;

	// Use this for initialization
	void Start ()
    {
        rigi = GetComponent<Rigidbody>();
	}
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spinny = !spinny;
        }
    }
    
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        
        mySpeed = Vector3.zero;
        mySpeed += transform.forward * 20 * Input.GetAxis("Vertical");
        mySpeed.y = rigi.velocity.y;
        rigi.velocity = mySpeed;
        /*
        // Movement forwards and backwards
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(0f, 0f, 0.2f);
            rigi.AddRelativeForce(0f, 0f, 2000f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(0f, 0f, -5f * Time.deltaTime);
            rigi.AddRelativeForce(0f, 0f, -1200f * Time.deltaTime);
        }
        // Turn left and right
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Rotate(0f, -5f, 0f);
            rigi.AddTorque(0f, -1000f * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Rotate(0f, 5f, 0f);
            rigi.AddTorque(0f, 1000f * Time.deltaTime, 0f);
        }
        */

        //rigi.velocity = (transform.forward * 20 * Input.GetAxis("Vertical")) + (Vector3.down * 9.81f);
        transform.Rotate(0f, 200f * Input.GetAxis("Horizontal") * Time.deltaTime, 0f);
        if (spinny)
        {
            rigi.AddRelativeForce((Vector3.up + Vector3.forward / 2) * 50);
        }
    }
}