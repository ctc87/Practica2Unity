using UnityEngine;
using System.Collections;

public class SpidersJumpAndWalk : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "player_1") {
			GameController.isActivatedSphereActions = !GameController.isActivatedSphereActions;
		}
	}
}
