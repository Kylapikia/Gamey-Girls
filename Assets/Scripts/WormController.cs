using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WormController : MonoBehaviour {

	//public string state;
	public GameObject player;
	public float sight = 6f;
	public float stoppingDistence = 3f;

	public Text text;

	public int wormCount;

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		wormCount = 0;
	}
	
	void FixedUpdate () {
		
		anim.SetBool ("Moving", false);
		Squirming (player);
	}

	void Squirming(GameObject target){
		float distence = Vector3.Distance (transform.position, target.transform.position);

		if (distence < sight && distence < stoppingDistence) {
			anim.SetBool ("Moving", true);
		}
	}

	void OnTriggerEnter2D (Collider2D other){
		if(other.name == "Player"){
			Destroy (this);
			wormCount++;
			text.text = text;
		}
	}
}
