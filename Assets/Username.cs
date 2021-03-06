using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Username : MonoBehaviour {

	public InputField userName;

	string filePath;
	string resultsFile;
	string logFile;
	//string data;

	// Use this for initialization
	void Start () {
		filePath = Application.persistentDataPath + "/";
		resultsFile = "results.txt";
		logFile = "log.txt";
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	//Saves the username and loads the menu.
	public void saveName() {
		//Append a line with the username to the results file.
		System.IO.File.AppendAllText (filePath + resultsFile, "\n" + userName.text + "\n", System.Text.Encoding.UTF8);

		//Append a line with the username to the logfile.
		System.IO.File.AppendAllText (filePath + logFile, "\n" + userName.text + "\n", System.Text.Encoding.UTF8);

		//Save the username for use in other scenes.
		PlayerPrefs.SetString("username", userName.text);

		//Load the menu.
		SceneManager.LoadScene ("Menu");
	}
}
