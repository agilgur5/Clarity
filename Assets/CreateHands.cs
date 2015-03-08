using UnityEngine;
using System.Collections;

public class CreateHands : MonoBehaviour {


	public Transform LeftHand;
	public Transform RightHand;

	// Use this for initialization
	void Start () {
		Vector3 cameraVec = Camera.main.gameObject.transform.position;
		Instantiate (LeftHand, cameraVec + new Vector3(-0.25F, 0.25F, 1), Quaternion.identity);
		Instantiate (RightHand, cameraVec + new Vector3(0.25F, 0.25F, 1), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
