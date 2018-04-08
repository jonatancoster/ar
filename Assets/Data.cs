using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour {

	public GameObject cube;
	public GameObject ground;
	public Text textfield;
	public InputField namefield;

	string filePath;
	string filename;
	string data;

	// Use this for initialization
	void Start () {
		filePath = Application.persistentDataPath;
		filename = "ar.txt";
		data = "test";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void save() {
		//System.IO.File.WriteAllText (filePath + "/" + filename, data);
		System.IO.File.AppendAllText (filePath + "/" + filename, data);
	}

	public void saveName() {
		System.IO.File.AppendAllText (filePath + "/" + filename, namefield.text, System.Text.Encoding.UTF8);
	}

	public void savePosition() {
		System.IO.File.AppendAllText (filePath + "/" + filename, cube.transform.localPosition + "\n", System.Text.Encoding.UTF8);
	}
}
