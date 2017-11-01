﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject activeCheckpoint;
	private PlayerController_Hop player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController_Hop> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RespawnPlayer(){
		player.transform.position = activeCheckpoint.transform.position;
	}
}
