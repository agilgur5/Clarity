using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Wait5 ();
		//toggleScene ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Wait5() {
		yield return new WaitForSeconds (3);
	}

	// toggles between scene 1 and 0
	void toggleScene() {
		if (Application.loadedLevel == 0)
			Application.LoadLevel (1);
		else
			Application.LoadLevel (0);
	}
}
