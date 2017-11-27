using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate2 : MonoBehaviour {

	public float speed = 80f;		// rotating speed for circles 
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);  // Time.deltatime so that it doesn't rotate too quickly
	}
}
