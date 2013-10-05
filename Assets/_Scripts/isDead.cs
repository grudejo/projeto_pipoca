using UnityEngine;
using System.Collections;

public class isDead : MonoBehaviour {
	
	public GameObject dead;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (transform.position.y > dead.transform.position.y && CharController.grounded) {
			Debug.Log("Morreu");
			Application.LoadLevel(Application.loadedLevel);
		}
	}
	
	 void OnTriggerEnter(Collider other) {
        
    }
	
}
