using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed;
    private float maxSpeed = 50f;
    private Vector3 input;
    public Rigidbody rb3D;
    // Use this for initialization
    void Start () {
        rb3D = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if(rb3D.velocity.magnitude < maxSpeed) {
            rb3D.AddForce(input * moveSpeed);
        }
	}
}
