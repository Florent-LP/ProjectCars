using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {
	protected int currentCheckPoint = 0;
	protected int currentLap = 0;
	public int maxLaps = 1;
	public GameObject[] checkPoints;
	public GameObject lapsUI;
	public GameObject winnerUI;
	protected Text printLap = null;
	protected Text printWinner = null;

	// Use this for initialization
	void Start () {
		printLap = lapsUI.GetComponent<Text> ();
		if (printLap != null) printLap.text = "Tour : " + currentLap + "/" + maxLaps;
		printWinner = winnerUI.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider c) {
		if (c.gameObject.tag == "CheckPoint") {
			if (currentCheckPoint + 1 >= checkPoints.Length && c.gameObject == checkPoints [0]) {
				currentCheckPoint = 0;
				currentLap++;

				if (printLap != null) printLap.text = "Lap : " + currentLap + "/" + maxLaps;
				Debug.Log ("Player: "+ gameObject.name + ", CheckPoint: " + currentCheckPoint + ", Lap: " + currentLap);

				if (currentLap == maxLaps)
					gameOver (gameObject.name);
			} else if (c.gameObject == checkPoints [currentCheckPoint + 1]){
				currentCheckPoint++;

				if (printLap != null) printLap.text = "Lap : " + currentLap + "/" + maxLaps;
				Debug.Log ("Player: "+ gameObject.name + ", CheckPoint: " + currentCheckPoint + ", Lap: " + currentLap);
			}
		}
	}

	void gameOver(string winnerName) {
		Debug.Log ("Player "+ winnerName + " won !");
		if (printWinner != null) printWinner.text = winnerName + " won !";
		StartCoroutine(Coroutine());
	}

	IEnumerator Coroutine() {
		yield return new WaitForSeconds (5);
		SceneManager.LoadScene ("Menu");
		yield break;
	}
}
