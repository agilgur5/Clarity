using UnityEngine;
using System.Collections;
using System.IO;
using System.Net.Sockets;

public class TCPSocketReader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject guiText = new GameObject ();
		Instantiate (guiText);
		GUIText text = guiText.AddComponent<GUIText> ();
		text.transform.position = new Vector3 (0.5F, 0.5F, 0.5F);
		TcpClient handClient = new TcpClient("ngrok.com", 46595);
		try{
			Stream handStream = handClient.GetStream();
			StreamReader handReader = new StreamReader(handStream);

			//handStream.Close ();
		} finally {
			//handClient.Close ();
		}
	
	}
	
	// Update is called once per frame
	void Update () {
//		text.guiText.text = handReader.ReadLine ();
	}
}
