using UnityEngine;
using System.Collections;

public class CLifeDuration : MonoBehaviour {
	protected int t = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ((++t) % 1500 == 0) {
			Destroy(gameObject);
		}
	}
}
