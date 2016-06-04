﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(Coroutine());
	}

	IEnumerator Coroutine(){
		yield return new WaitForSeconds (5);
		Destroy (gameObject);
		yield break;
	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.tag == "Player") {
			CarUserControl carCtrl = c.gameObject.GetComponent<CarUserControl>();
			if (carCtrl != null) carCtrl.StunCar();
		}
	}

}