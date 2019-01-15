using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    Rigidbody rb;
    public float Speed;
	// Use this for initialization
	void Start () {
        Speed = 0.25f;
        rb = GetComponent<Rigidbody>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveJump = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(moveHorizontal, moveJump, moveVertical);
        rb.AddForce(movement * Speed);
        
        rb.AddForce(new Vector3(0.0f, 9.8f, 0.0f));
    }
}
