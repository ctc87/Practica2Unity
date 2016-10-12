using UnityEngine;
using System.Collections;

public class SpiderEnemy : MonoBehaviour {

	private Animator animator;
	void Start() {
		if(tag == "Walker")
			GameController.enemyDoActionReleased += walk;
		else if(tag == "Jumper")
			GameController.enemyDoActionReleased += jump;
	}
		
	void walk(bool activate) {
		animator = GetComponent<Animator>();
		if (activate) {
			animator.ResetTrigger ("StopJump");
			animator.SetTrigger ("Jump");
		} else {
			animator.ResetTrigger("Jump");
			animator.SetTrigger("StopJump");
		}
	}

	void jump(bool activate) {
		animator = GetComponent<Animator>();
		if (activate) {
			animator.ResetTrigger("StopWalk");
			animator.SetTrigger ("Walk");
		} else {
			animator.ResetTrigger("Walk");
			animator.SetTrigger ("StopWalk");
		}
	}
}
