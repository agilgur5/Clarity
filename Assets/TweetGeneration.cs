using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class TweetGeneration : MonoBehaviour {

	// Use this for initialization
	void Start () {
		FileInfo theSourceFile = null;
		StringReader reader1 = null; 
		StringReader reader2 = null;
		
		TextAsset list = (TextAsset)Resources.Load("list", typeof(TextAsset));
		TextAsset matrix = (TextAsset)Resources.Load("matrix", typeof(TextAsset));

		reader1 = new StringReader(list.text);
		reader2 = new StringReader(matrix.text);

		if ( reader1 == null )
		{
			Debug.Log("list.txt not found or not readable");
		}
		if ( reader2 == null )
		{
			Debug.Log("matrix.txt not found or not readable");
		}
		else
		{
			string text1;
			string text2;
			// Read each line from the file
			while ((text1 = reader1.ReadLine()) != null){
				Debug.Log (text1);
				// Getting the data from the matrix
				char[] delimiterChars = { ' ', ',', ':', '\t' };
				text2 = reader2.ReadLine();
				Debug.Log (text2);

				string[] words = text2.Split(delimiterChars);

				float xx = float.Parse(words[0]);
				float yy = float.Parse(words[2]);
				float zz = float.Parse(words[4]);

				CreateText (text1, xx, yy, zz);
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Transform TextPrefab;
	// create 3d text mesh from prefab
	void CreateText(string text, float x, float y, float z) {
		Transform txtMeshTransform = (Transform)Instantiate (TextPrefab, new Vector3(x, y, z), Quaternion.identity);

		TextMesh txtMesh = txtMeshTransform.GetComponent<TextMesh> ();
		txtMesh.text = text;
		Debug.Log (text);
	}
}
