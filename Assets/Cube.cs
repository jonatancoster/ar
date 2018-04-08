using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	Vector3 distance = new Vector3(0f, 0.1f, 0f);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoveDown() {
		this.gameObject.transform.Translate (-distance, Space.Self);
	}

	public void MoveUp() {
		this.gameObject.transform.Translate (distance, Space.Self);
	}
}
