using UnityEngine;
using System.Collections;

public class RotateAndChangeMaterial : MonoBehaviour {

	bool enter;
	public Material[] materials;
	public Renderer rend;
	public float rotateSpeed;


	// Use this for initialization
	void Start () {
		rotateSpeed = 20.0f;
		enter = false;
	}

	// Update is called once per frame
	void Update () {
		if (enter) {
			rend.sharedMaterial = materials [1];
			transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
		} else {
			rend.sharedMaterial = materials [0];
		}

	}
		

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "player_1") {
			Debug.Log ("entrado");
			(enter) = true;
		}
	}

}
