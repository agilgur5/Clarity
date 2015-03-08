using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class GetKinect : MonoBehaviour {
	
	static string url = "https://raw.githubusercontent.com/php/playground/master/HelloWorld.txt";
	private WWW www;
	public String message;
	public long timestamp;
	public bool go;
	public Text allo;
	Text alla;
	
	void Start () {
		go = true;
		alla = GetComponent<Text>();
	}
	
	
	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;
		
		// The text that will be retrieve will have the following form:
		// TEXT ------- \t POSITIVE_INDEX
		
		
		// check for errors
		if (www.error == null)
		{
			string text = www.text;
			Debug.Log (text);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}
		
	}
	
	void Update () {
		
		if (Time.frameCount % 20 == 0) {
			Debug.Log ("Hello");
			www = new WWW (url);
			go = true;
			StartCoroutine(WaitForRequest(www));
			alla.text = "My cat died"; // message;
			Debug.Log(message);
		}
	}
	
}