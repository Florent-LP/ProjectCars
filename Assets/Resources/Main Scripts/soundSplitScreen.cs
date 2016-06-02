using UnityEngine;
using System.Collections;

public class soundSplitScreen : MonoBehaviour {

	public Transform camera1;
	public Transform camera2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = (camera1.position/2 + camera2.position/2);
	}
}
