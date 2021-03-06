﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManController : MonoBehaviour {

    public Rigidbody2D player;
    public float speed;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void FixedUpdate() {
        // Only moving in one direction (whether its side-by-side or up & down)
        if (Input.GetKey(KeyCode.UpArrow)) {
            player.velocity = new Vector2(0, speed);
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            player.velocity = new Vector2(0, -speed);
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            player.velocity = new Vector2(-speed, 0);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            player.velocity = new Vector2(speed, 0);
        }
    }
}
