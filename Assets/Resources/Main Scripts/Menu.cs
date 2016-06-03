using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect (Screen.width/2-300,Screen.height/2-100,250,250), "Project Car");

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect (Screen.width/2-300,Screen.height/2-50, 250, 50), "Play Game")) {
			SceneManager.LoadScene ("Scene");
		}
	}
}
