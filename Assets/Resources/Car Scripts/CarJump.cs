using UnityEngine;
using System.Collections;

public class CarJump : MonoBehaviour {

	public Rigidbody rb;
	public float jumpSpeed = 100f;
	public KeyCode jumpControl;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (jumpControl)){
			rb.velocity += jumpSpeed * Vector3.up;
		} 
	}
}
