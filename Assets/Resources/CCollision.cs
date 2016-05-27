using UnityEngine;
using System.Collections;

public class CCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c) {
		if (c.gameObject.name.Contains("Wooden Hut"))
			Destroy(c.gameObject);
	}
}
