using UnityEngine;
using System.Collections;


public class GameController : MonoBehaviour {

	public static bool isActivatedSphereActions = false;

	public delegate void EenemyDoActionDelegate (bool activate);
	public static event EenemyDoActionDelegate enemyDoActionReleased;

	void Update() { 
		if (enemyDoActionReleased != null) {
			if (isActivatedSphereActions)
				enemyDoActionReleased (true);
			else
				enemyDoActionReleased (false);
		}
	}

}
