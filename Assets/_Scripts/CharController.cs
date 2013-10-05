using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {
	
	public float gravity;	
	public float velocityPlayer, jump;
	public Vector3 move;
	public static bool grounded = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		move = new Vector3(
		//X
			Input.GetAxis("Horizontal")  * velocityPlayer * Time.deltaTime,	
		//Y
			gravity,
		//Z
			0);
		
		if (Input.GetButtonUp("Jump")) {
			if (grounded) {
				Debug.Log("Pulo?");
				move.y += jump;
			}
		}
        
		rigidbody.AddForce(move, ForceMode.Impulse);
	}
	
	void OnCollisionEnter()
	{
		Debug.Log ("Entrou em colisao");
		grounded = true;
	}

	void OnCollisionExit()
	{
		Debug.Log ("Saiu da colisao");
		grounded = false;
	}	
	
}
