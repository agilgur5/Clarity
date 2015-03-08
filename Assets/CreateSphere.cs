using UnityEngine;
using System.Collections;

public class CreateSphere : MonoBehaviour {

	/*
	 * This code is HEAVILY inspired by the tutorial "Brick Shooter". So if you have trouble understanding, go look at this tutorial.
	 */

	const float armNormalValue = 8f; // "Diameter" of the environment. Ideally, should be taken by the Kinect.
	const float min_space = 0.2f; // The minimal space between balls
	const float r_circle = 1f; // The diameter of a ball (ideally, should be taken directly from the prefab of the sphere)
	public Rigidbody sphere; // The prefab of the sphere
	public Transform oculusCam;
	
	void Start () {
		Vector3 cameraValues = oculusCam.GetComponent<Transform>().position; // Take the xyz of the camera
		for (float pi = 0; pi <= (Mathf.PI); pi = pi + (Mathf.PI/10)) { // (Using spherical coordinates)
			// How many balls should we display every "row"? 
			float circ = Mathf.PI * 2 * armNormalValue * Mathf.Sin(pi); // calculating the circumference of each "row"
			int n_circles = (int) (circ / ((r_circle * 2) + min_space)); // how many balls do you need on this row?
			if (n_circles <= 1){ // making sure there are circles
				n_circles = 1;
			}
			for (float theta = 0; theta <= 2 *(Mathf.PI); theta = theta + (Mathf.PI/n_circles)){ // Display all the balls of the "row"
				Vector3 vec = new Vector3(armNormalValue * Mathf.Sin(pi) * Mathf.Cos(theta), // Transforming from spherical to cartesian
				                          armNormalValue * Mathf.Cos(pi),  					// y and z are inversed!
				                          armNormalValue * Mathf.Sin(pi) * Mathf.Sin(theta)); 
				Instantiate(sphere, vec + cameraValues , Quaternion.AngleAxis(0, Vector3.zero)) ; // creating the ball
			}
		}
	}
}

/*
 * 		for (float pi = 0; pi <= 2 *(Mathf.PI ); pi = pi + (Mathf.PI)) {
			float circ = Mathf.PI * 2 * armNormalValue * Mathf.Sin(pi);
			float n_circles =  (circ / (r_circle + min_space));
			Debug.Log(circ + " (circ) " + r_circle + " (r_circle) " + n_circles + " (n_circles)");
			for (float theta = 0; theta <= 2*(Mathf.PI); theta = theta + (Mathf.PI/10)){
*/