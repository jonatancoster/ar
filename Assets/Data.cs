using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Data : MonoBehaviour {

	public GameObject virtualObject;
	public InputField userName;

	string filePath;
	string resultsFile;
	string logFile;
	float startTime;

	// Use this for initialization
	void Start () {
		filePath = Application.persistentDataPath + "/";
		resultsFile = "results.txt";
		logFile = "log.txt";

		//Save the start time.
		startTime = Time.time;

		//Start recording virtual object position to the log file.
		InvokeRepeating ("savePosition", 0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public void saveObjectType(string type) {
		Debug.Log (type);
	}



	//Used when the user has entered a name.
	public void saveName() {
		//Append a line with the username to the results file.
		System.IO.File.AppendAllText (filePath + resultsFile, userName.text + "\n", System.Text.Encoding.UTF8);

		//Append a line with the username to the logfile.
		System.IO.File.AppendAllText (filePath + logFile, userName.text + "\n", System.Text.Encoding.UTF8);

		//Save the username for use in other scenes.
		PlayerPrefs.SetString("username", userName.text);

		//Load the menu.
		SceneManager.LoadScene ("Menu");
	}



	//Used to regularly save the position of the object and the time to the log file.
	public void savePosition() {
		//Distance from ground to virtual object. Object scale = 0.5.
		float distance = (virtualObject.transform.localPosition.y - 0.25f);

		float playTime = Time.time - startTime;

		//Write the distance from ground to object, object global y position and time.
		System.IO.File.AppendAllText (filePath + logFile, distance.ToString() + "\t" + virtualObject.transform.position.y.ToString() + "\t" + playTime.ToString() + "\n", System.Text.Encoding.UTF8);
	}



	//Used to save the position of the object and the time to the results file when the user press the ok button.
	public void userOK() {
		//Distance from ground to virtual object. Object scale = 0.5.
		float distance = (virtualObject.transform.localPosition.y - 0.25f);

		float playTime = Time.time - startTime;

		//Write the distance from ground to object, object global y position and time.
		System.IO.File.AppendAllText (filePath + resultsFile, distance.ToString() + "\t" + virtualObject.transform.position.y.ToString() + "\t" + playTime.ToString() + "\n", System.Text.Encoding.UTF8);

		//Quit recording.
		CancelInvoke();

		//Load the menu.
		SceneManager.LoadScene ("Menu");
	}
}
