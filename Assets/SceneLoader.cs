using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void loadCubeShadow() {
		SceneManager.LoadScene("Cube_Shadow");
	}

	public void loadCube() {
		SceneManager.LoadScene("Cube");
	}

	public void loadSphereShadow() {
		SceneManager.LoadScene("Sphere_Shadow");
	}

	public void loadSphere() {
		SceneManager.LoadScene("Sphere");
	}

	public void quit() {
		Application.Quit ();
	}
}
