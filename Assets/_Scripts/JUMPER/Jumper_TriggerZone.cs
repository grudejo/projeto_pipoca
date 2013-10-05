using UnityEngine;
using System.Collections;

public class Jumper_TriggerZone : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider hit) {
		if(hit.CompareTag("Player")){
			Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Plataform"), true);
		}
	}
	
	void OnTriggerExit (Collider hit) {
		if(hit.CompareTag("Player")){
			Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Plataform"), false);
		}
	}
	
	
}
