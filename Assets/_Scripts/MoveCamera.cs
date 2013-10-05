﻿using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	
	public float velocity;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (	transform.position.x,
											transform.position.y + velocity * Time.deltaTime,
											transform.position.z); 
			
	}
}
