using UnityEngine;
using System.Collections;

public class TweetGeneration : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CreateText ("poop", 5, 5, 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Transform TextPrefab;
	// create 3d text mesh from prefab
	void CreateText(string text, int x, int y, int z) {
		Transform txtMeshTransform = (Transform)Instantiate (TextPrefab, new Vector3(x, y, z), Quaternion.identity);

		TextMesh txtMesh = txtMeshTransform.GetComponent<TextMesh> ();
		txtMesh.text = text;
	}
}
