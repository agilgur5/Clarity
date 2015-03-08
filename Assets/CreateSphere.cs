using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class CreateSphere : MonoBehaviour {

	/*
	 * This code is HEAVILY inspired by the tutorial "Brick Shooter". So if you have trouble understanding, go look at this tutorial.
	 */

	const float armNormalValue = 8f; // "Diameter" of the environment. Ideally, should be taken by the Kinect.
	const float min_space = 4f; // The minimal space between balls
	const float r_circle = 1f; // The diameter of a ball (ideally, should be taken directly from the prefab of the sphere)
	public Rigidbody sphere; // The prefab of the sphere
	public Transform oculusCam;
	
	void Start () {

		// TEXT INIT
		FileInfo theSourceFile = null;
		StringReader reader1 = null; 
		StringReader reader2 = null;
		StringReader reader3 = null;
		
		TextAsset list = (TextAsset)Resources.Load("list", typeof(TextAsset));
		TextAsset matrix = (TextAsset)Resources.Load("matrix", typeof(TextAsset));
		TextAsset sentiment = (TextAsset)Resources.Load("sentiment", typeof(TextAsset));

		reader1 = new StringReader(list.text);
		reader2 = new StringReader(matrix.text);
		reader3 = new StringReader (sentiment.text);

		string text1;
		string text2;
		string text3;
			
			
			
			Vector3 cameraValues = oculusCam.GetComponent<Transform>().position; // Take the xyz of the camera
		for (int i = 0; i <= 30; i++) { 
			// Read each line from the file
			text1 = reader1.ReadLine();
			text2 = reader2.ReadLine();
			text3 = reader3.ReadLine();
			Debug.Log (text3);

			if (text1 != null){
				// Getting the data from the matrix
				
				char[] delimiterChars = { ' ', ',', ':', '\t' };
				string[] words = text2.Split(delimiterChars);
				float xx = float.Parse(words[0]);
				float yy = float.Parse(words[2]);
				float zz = float.Parse(words[4]);
				Vector3 vecvec2 = new Vector3(xx / 3.5f, yy/5f + 3, zz/4f - 6f);

				// COLOR
				float color = float.Parse(text3);

				if (vecvec2.y >= 0f){
					GameObject sp = Instantiate(sphere, vecvec2, Quaternion.AngleAxis(0, Vector3.zero)) as GameObject; 
					Debug.Log (i);// creating the ball
					CreateText (text1, vecvec2.x, vecvec2.y, vecvec2.z);
				}
				
				}
			}
		}

	public Transform TextPrefab;

	void CreateText(string text, float x, float y, float z) {
		Transform txtMeshTransform = (Transform)Instantiate (TextPrefab, new Vector3(x, y, z), Quaternion.identity);
		
		TextMesh txtMesh = txtMeshTransform.GetComponent<TextMesh> ();
		txtMesh.text = text;
	}

}

/*
 * 		for (float pi = 0; pi <= 2 *(Mathf.PI ); pi = pi + (Mathf.PI)) {
			float circ = Mathf.PI * 2 * armNormalValue * Mathf.Sin(pi);
			float n_circles =  (circ / (r_circle + min_space));
			Debug.Log(circ + " (circ) " + r_circle + " (r_circle) " + n_circles + " (n_circles)");
			for (float theta = 0; theta <= 2*(Mathf.PI); theta = theta + (Mathf.PI/10)){
*/

/*
 * 
*/