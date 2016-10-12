using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class OpenDoor : MonoBehaviour {

	float smooth;
	float DoorOpenAngle;
	float DoorCloseAngle;
	bool open;
	bool enter; 
	public AudioSource audioOpen;
	public AudioSource audioClose;

	void Start() {
		smooth = 2.0f;
		DoorOpenAngle = -90f;
		DoorCloseAngle = 0.0f;
		open = false;
		enter = false;
	}
	// Smothly open a door

	//Main function
	void Update ( ){

		if(open == true){
			var target = Quaternion.Euler (0, DoorOpenAngle, 0);
			// Dampen towards the target rotation
			transform.localRotation = Quaternion.Slerp(transform.localRotation, target,
				Time.deltaTime * smooth);
		}
		if(open == false){
			var target1 = Quaternion.Euler (0, DoorCloseAngle, 0);
			// Dampen towards the target rotation
			transform.localRotation = Quaternion.Slerp(transform.localRotation, target1,
				Time.deltaTime * smooth);
		}

		if(enter == true){
			if(Input.GetKeyDown("f")) {
				open = !open;
				StartCoroutine(playEngineSound());
			}
		}

	}

	//Activate the Main function when player is near the door
	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "player_1") {
			(enter) = true;
		}
	}

	//Deactivate the Main function when player is go away from door
	void OnTriggerExit (Collider other){

		if (other.gameObject.tag == "player_1") {
			(enter) = false;
		}
	}

	IEnumerator playEngineSound()
	{
		audioOpen.Play ();
		if (!open) {
			yield return new WaitForSeconds (audioOpen.clip.length);
			audioClose.Play ();
		}
	}

}
