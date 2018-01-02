using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyController : MonoBehaviour {

    private Rigidbody2D myrb;
    public float bunnyJumpForce = 500f;

	// Use this for initialization
	void Start () {
        myrb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            myrb.AddForce(transform.up * bunnyJumpForce);
        }
	}
}
