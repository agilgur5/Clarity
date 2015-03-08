using UnityEngine;
using System.Collections;
using System.IO;
using System.Net.Sockets;

public class TCPSocketReader : MonoBehaviour {

	/*StreamReader handReader;
	TcpClient handClient;
	Stream handStream;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		handClient = new TcpClient("ngrok.com", 46595);
		try{
			handStream = handClient.GetStream();
			handReader = new StreamReader(handStream);
			string text = handReader.ReadLine();
			Debug.Log (text);
			//	handStream.Close ();
		} finally {
			//	handClient.Close ();
		}
	}*/
}
