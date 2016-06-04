using UnityEngine;
using System.Collections;

public class respawnManager : MonoBehaviour {
	protected Vector3 initialPos;
	protected Quaternion initialRot;
	protected Rigidbody rb;
	protected Vector3 lastCheckPos;
	protected Quaternion lastCheckRot;

	// Use this for initialization
	void Start () {
		initialPos = gameObject.transform.position;
		initialRot = gameObject.transform.rotation;
		lastCheckPos = initialPos;
		lastCheckRot = initialRot;
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider c) {
		if (c.gameObject.tag == "Respawn") {
			gameObject.transform.position = lastCheckPos;
			gameObject.transform.rotation = lastCheckRot;
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
		} else if (c.gameObject.tag == "CheckPoint") {
			lastCheckPos = c.gameObject.transform.position;
			lastCheckRot = c.gameObject.transform.rotation;
		}
			
	}
}
