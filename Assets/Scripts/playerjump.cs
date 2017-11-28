using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerjump : MonoBehaviour {

    public float jumpSpeed = 5f;
    private Rigidbody2D body;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))     // if screen is tapped or left mouse button is pressed; 0 is for left mouse button
        {
            body.velocity = Vector2.up * jumpSpeed; // Vector2 is for 2d space
        }
	}
}
