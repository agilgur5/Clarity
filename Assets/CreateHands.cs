using UnityEngine;
using System.Collections;

public class CreateHands : MonoBehaviour {


	public Transform LeftHand;
	public Transform RightHand;
	public Transform oculusCam;

	// Use this for initialization
	void Start () {
		Vector3 cameraVec = oculusCam.GetComponent<Transform>().position;
		Instantiate (LeftHand, cameraVec + new Vector3(-0.5F, 0.25F, 2), Quaternion.identity);
		Instantiate (RightHand, cameraVec + new Vector3(0.5F, 0.25F, 2), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void calculateDistance() {
		Vector3 leftDist = LeftHand.position - Camera.main.gameObject.transform.position;
		Camera.main.gameObject.transform.position += (new Vector3(0.9f * leftDist.x, 0.9f * leftDist.y, 0.9f * leftDist.z));

		Vector3 rightDist = RightHand.position - Camera.main.gameObject.transform.position;
		Camera.main.gameObject.transform.position += (new Vector3(0.9f * rightDist.x, 0.9f * rightDist.y, 0.9f * rightDist.z));
	}

	// using the ray from origin through midpoint, calculate if an object has been collided with
	private bool raycastCollision(Transform origin, Transform midpoint, Transform target) {
		return false;
	}


}
