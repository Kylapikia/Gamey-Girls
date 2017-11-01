using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrocController : MonoBehaviour {

	public LevelManager levelManager;

	//public string state;
	public GameObject player;
	public float sight = 6f;
	public float stoppingDistence = 3f;

	private Animator anim;

	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate () {

		anim.SetBool ("Snap", false);
		Snap (player);
	}

	void Snap(GameObject target){
		float distence = Vector3.Distance (transform.position, target.transform.position);

		if (distence < sight && distence < stoppingDistence) {
			anim.SetBool ("Snap", true);
		}
	}

	void OnTriggerEnter2D (Collider2D other){
		if(other.name == "Player"){
			levelManager.RespawnPlayer();
		}
	}
}
