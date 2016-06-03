using UnityEngine;

using System.Collections;

public class Camera_rotate : MonoBehaviour {

	public GameObject repere;
	public int vitesse;
	private float speed = 50f;
	public bool fadein = false;
	private Vector3 finalPos = new Vector3(-145.4976f,221.4501f,68.58565f);
	private Vector3 finalAngle = new Vector3(0f,72f,0f);
	public Vector3 angle;
	public Vector3 camPos;
	public Vector3 camAngle;
	public Vector3 pos;
	public Vector3 anglec;
	public GameObject image;

	// Use this for initialization
	void Update() {
		angle = Camera.main.transform.rotation.eulerAngles;
		pos = Camera.main.transform.position;

		// Spin the object around the world origin at 20 degrees/second.
		if (!fadein) {
			transform.RotateAround (repere.transform.position, Vector3.up, vitesse * Time.deltaTime);
		} else {
			//Camera.main.transform.Rotate( 0.1f*calculRotation(angle.z, finalAngle[2])*Time.deltaTime,0.1f*calculRotation(angle.x,finalAngle[0])*Time.deltaTime,0.01f*calculRotation(angle.y, finalAngle[1])*Time.deltaTime);
			//Camera.main.transform.Translate(new Vector3(speed*calculMouvement(pos.x,finalPos[0]), speed*calculMouvement(pos.y, finalPos[1]), speed * calculMouvement(pos.z, finalPos[2]))*Time.deltaTime, null);
			//image.transform.Translate(new Vector3(10,0,0)*Time.deltaTime);
			Camera.main.transform.position = Vector3.MoveTowards (Camera.main.transform.position, finalPos, Time.deltaTime * speed);
			camPos = Camera.main.transform.position;
			camAngle = Camera.main.transform.eulerAngles;

			Vector3 target = repere.transform.position - Camera.main.transform.position;
			Vector3 newDir = Vector3.RotateTowards(Camera.main.transform.forward, target, Time.deltaTime, 0.0f);
			Camera.main.transform.rotation = Quaternion.LookRotation(newDir);
			anglec = Camera.main.transform.eulerAngles - finalAngle;
			if(Vector3.Distance(Camera.main.transform.position, finalPos)<0.001f && Mathf.Sqrt(anglec.x * anglec.x + anglec.y * anglec.y + anglec.z * anglec.z)<2f)
				Application.LoadLevel(1);
		}
	

		}

	public void onFadeIn(){
		fadein = true;
		image.SetActive (false);
	}

	/**
	 * Calcule le mouvement à effectuer pandant cette affichage
	 * actuel: angle ou position actuelle suivant un axe
	 * final : poisition à atteindre suivant le meme axe que précedement
	 **/
	private float calculMouvement(float actuel, float final){
		float dm = final - actuel;
		if (Mathf.Abs (dm) < 0.05) {
			dm = 0;
		} 
		return dm;
	}

	private float calculRotation(float actuel, float final){
		float dm = actuel - final;

		if (dm < 0)
						dm = 360 - dm;
		if (dm < 0.1 && dm > - 0.1)
			dm = 0;
		return dm;
	}
}
