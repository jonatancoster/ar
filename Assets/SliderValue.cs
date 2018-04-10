using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour {

	public GameObject cube;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetPosition() {
		cube.transform.position = new Vector3 (cube.transform.position.x, this.gameObject.GetComponent<Slider> ().value, cube.transform.position.z);
	}
}
