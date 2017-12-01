using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject a;
	public GameObject b;
	public GameObject c;
	public GameObject d;
	public GameObject cube;

	private float timeCounter = 0;
	public float delay = 0.200f; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime;
	

		if (timeCounter > delay) {
			Debug.Log (timeCounter);

			timeCounter = 0;

			GameObject currentCube = Instantiate (cube);
			currentCube.transform.position = a.transform.position;
		}
	}
}
