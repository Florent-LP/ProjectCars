using UnityEngine;
using System.Collections;

public class respawnManager : MonoBehaviour {
	protected Vector3 initialPos;
	protected Quaternion initialRot;
	protected Rigidbody rb;

	// Use this for initialization
	void Start () {
		initialPos = gameObject.transform.position;
		initialRot = gameObject.transform.rotation;
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Terrain") {
			gameObject.transform.position = initialPos;
			gameObject.transform.rotation = initialRot;
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
		}
	}
}
