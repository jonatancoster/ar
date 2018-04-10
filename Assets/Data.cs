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
		//filename = "ar.txt";
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
		//Create a file named after the user and add the user's name to the first line.
		filename = namefield.text + ".txt";
		System.IO.File.AppendAllText (filePath + "/" + filename, namefield.text + "\n", System.Text.Encoding.UTF8);
	}



	public void savePosition() {
		
		//Distance from ground to cube. Cube scale = 0.5.
		float distance = (cube.transform.localPosition.y - 0.25f);

		//Write the distance from ground to cube, cube local y position and cube global y position.
		System.IO.File.AppendAllText (filePath + "/" + filename, distance.ToString() + "\t" + cube.transform.localPosition.y.ToString() + "\t" + cube.transform.position.y.ToString() + "\n", System.Text.Encoding.UTF8);
	}
}
