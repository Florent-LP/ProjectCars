using UnityEngine;
using System.Collections;

public class BulletDisappear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(Coroutine());
	}

	IEnumerator Coroutine(){
		yield return new WaitForSeconds (5);
		Destroy (gameObject);
		yield break;
	}

}
