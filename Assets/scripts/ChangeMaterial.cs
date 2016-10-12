using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour {

	bool enter;
	public Material[] materials;
	public Renderer rend;


	// Use this for initialization
	void Start () {
		enter = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (enter) {
			rend.sharedMaterial = materials [0];
		} else {
			rend.sharedMaterial = materials [1];
		}
	}

	void OnCollisionEnter(Collision other){

		if (other.gameObject.tag == "player_1") {
			(enter) = true;
		}
	}

	void OnCollisionExit (Collision other){
		if (other.gameObject.tag == "player_1") {
			(enter) = false;
		}
	}
}
