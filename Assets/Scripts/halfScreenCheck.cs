using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfScreenCheck : MonoBehaviour {

    public float cameraJumpSpeed = 19f;
    private Rigidbody2D halfBody;
	// Use this for initialization
	void Start () {
        halfBody = GetComponent<Rigidbody2D>();
	}
	
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            halfBody.velocity = Vector2.up * cameraJumpSpeed * 0.1f;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            halfBody.velocity = Vector2.up * cameraJumpSpeed * 0f;
        }
    }
}
