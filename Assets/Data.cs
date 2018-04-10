using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour {

	public GameObject cube;
	public GameObject ground;
	public GameObject cubeGraphics;
	public GameObject sphereGraphics;
	public Text textfield;
	public InputField namefield;
	public Toggle cubeToggle;
	public Toggle sphereToggle;

	string filePath;
	string filename;
	string graphics;
	//string data;

	// Use this for initialization
	void Start () {
		filePath = Application.persistentDataPath;
		//filename = "ar.txt";
		//data = "test";
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public void save() {
		//System.IO.File.WriteAllText (filePath + "/" + filename, data);
		//System.IO.File.AppendAllText (filePath + "/" + filename, data);
	}



	public void saveName() {
		//Save the type of chosen graphics. Use the chosen graphics type.
		if(cubeToggle.isOn == true && sphereToggle.isOn == false) {
			graphics = "cube";
			cubeGraphics.SetActive (true);
			sphereGraphics.SetActive (false);
		} else if(sphereToggle.isOn == true && cubeToggle.isOn == false) {
			graphics = "sphere";
			sphereGraphics.SetActive (true);
			cubeGraphics.SetActive (false);
		} else {
			graphics = "error";
		}

		//Create a file named after the user and the graphics type and add the user's name to the first line.
		filename = namefield.text + "_" + graphics + ".txt";
		System.IO.File.AppendAllText (filePath + "/" + "raw_" + filename, namefield.text + " " + graphics + "\n", System.Text.Encoding.UTF8);
	}



	public void savePosition() {
		//Distance from ground to cube. Cube scale = 0.5.
		float distance = (cube.transform.localPosition.y - 0.25f);

		//Write the distance from ground to cube, cube local y position and cube global y position.
		System.IO.File.AppendAllText (filePath + "/" + "raw_" + filename, distance.ToString() + "\t" + cube.transform.localPosition.y.ToString() + "\t" + cube.transform.position.y.ToString() + "\t" + Time.time.ToString() + "\n", System.Text.Encoding.UTF8);
	}



	public void record() {
		InvokeRepeating ("savePosition", 0f, 1.0f);
	}



	public void userOK() {
		//Distance from ground to cube. Cube scale = 0.5.
		float distance = (cube.transform.localPosition.y - 0.25f);

		//Write the distance from ground to cube, cube local y position and cube global y position.
		System.IO.File.AppendAllText (filePath + "/" + filename, distance.ToString() + "\t" + cube.transform.localPosition.y.ToString() + "\t" + cube.transform.position.y.ToString() + "\t" + Time.time.ToString() + "\n", System.Text.Encoding.UTF8);

		Application.Quit ();
	}
}
