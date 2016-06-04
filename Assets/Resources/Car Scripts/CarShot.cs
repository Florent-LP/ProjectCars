using UnityEngine;
using System.Collections;

public class CarShot : MonoBehaviour {

	public Rigidbody bullet;
	public GameObject emitter;

	public int ejectSpeed = 100;
	public double fireRate = 0.5;

	private double nextFire = 0.0;

	public AudioClip shootSound;

	public KeyCode shotControl; 


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(shotControl) && Time.time > nextFire){
			nextFire = Time.time + fireRate;

			Rigidbody projectile;
			Bullet bulletComp = bullet.GetComponent<Bullet> ();
			if (bulletComp != null)
				bulletComp.emitter = emitter;
			projectile = (Rigidbody)Instantiate (bullet, transform.position, transform.rotation);
			projectile.velocity = transform.TransformDirection (Vector3.forward * ejectSpeed);
		
			GetComponent<AudioSource>().PlayOneShot (shootSound);
		}

	}
}
