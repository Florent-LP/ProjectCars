using UnityEngine;
using System.Collections;

public class CarShot : MonoBehaviour {

	public Rigidbody bullet;
	public float jumpSpeed = 100f;

	public int ejectSpeed = 100;
	public double fireRate = 0.5;

	private double nextFire = 0.0;
	private bool fullAuto = false;

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("p") && Time.time > nextFire){
			nextFire = Time.time + fireRate;

			Rigidbody projectile;
			projectile = (Rigidbody)Instantiate (bullet, transform.position, transform.rotation);
			projectile.velocity = transform.TransformDirection (Vector3.forward * ejectSpeed);
		}

		if (Input.GetKeyDown ("m")){
//			transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
			rb.velocity += jumpSpeed * Vector3.up;

//			rb.AddForce(Vector3.up * 100, ForceMode.Impulse);
//			rb.AddForce(Vector3.up * jumpSpeed);

		} 


	}
}
