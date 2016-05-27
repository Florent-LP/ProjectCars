using UnityEngine;
using System.Collections;

public class CAddSphere : MonoBehaviour {
	protected int t = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((t++) % 100 == 0) {
			GameObject lava = (GameObject)Instantiate (Resources.Load ("Lava"));
			Vector3 spawn = gameObject.transform.position;
			lava.transform.position = new Vector3 (spawn.x, spawn.y, spawn.z);
		}
	}
}
