using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CreateRandomObjects : MonoBehaviour {

	public GameObject prefab;
	public Vector3 positionMin, positionMax, positionFinal, scale;
	public int maxNumberObjects, minNumberObjects, numberObjects;
	private Transform father;		
	private int jumperOrWalker;


//	GameObject Spehere = get 

	// Use this for initialization
	void Start () {
		maxNumberObjects = 20;
		minNumberObjects = 5;
		scale = new Vector3 (0.02554421f, 0.03405894f, 0.0255442f);
		positionMin = new Vector3 (-0.9f, -0.9f, 0f);
		positionMax = new Vector3 (0.9f, 0.9f, 0.5f);
		father = this.transform.parent;

		numberObjects = Random.Range (minNumberObjects, maxNumberObjects + 1);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "player_1") {
//			Debug.Log ("object number: " + numberObjects );
			for (int i = 0; i < numberObjects; i++) {
				positionFinal = new Vector3 (
					Random.Range (positionMin.x, positionMax.x),
					Random.Range(positionMin.y, positionMax.y),
					Random.Range(positionMin.z, positionMax.z)
				);
			
				GameObject childObject = Instantiate(prefab, positionFinal,  Quaternion.identity) as GameObject;
				childObject.transform.parent = father.transform;
				childObject.transform.localPosition = positionFinal;
				childObject.transform.localScale = scale;
				jumperOrWalker = Random.Range (0, 2);
				if(System.Convert.ToBoolean(jumperOrWalker))
					childObject.tag = "Jumper";
				else
					childObject.tag = "Walker";

			}
		}
	}
}
