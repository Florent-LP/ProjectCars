using UnityEngine;
using System.Collections;

public class CarJump : MonoBehaviour {

	public Rigidbody rb;
	public float jumpSpeed = 100f;
	public KeyCode jumpControl;

	public double JumpRate = 0.5;
	private double nextJump = 0.0;



	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (jumpControl) && Time.time > nextJump){
			nextJump = Time.time + JumpRate;
			rb.velocity += jumpSpeed * Vector3.up;
		} 
	}
}
