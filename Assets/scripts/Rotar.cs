using UnityEngine;
using System.Collections;

public class Rotar : MonoBehaviour {
	public float rotateSpeed;
	// Use this for initialization
	void Start () {
		rotateSpeed = 30.0f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
	}
}
