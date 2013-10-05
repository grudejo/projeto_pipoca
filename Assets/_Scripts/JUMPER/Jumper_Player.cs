using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody))]

public class Jumper_Player : MonoBehaviour {
	
	public float force=800.0f;
	public float speed=5.0f;

	// Use this for initialization
	void Start () {
	rigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
	}
	
	// Update is called once per frame
	void Update () {
		
		
#if UNITY_ANDROID
		
		float moveX = Mathf.Clamp (Input.acceleration, -1.0f, 1.0f)*speed*Time.deltaTime;
		transform.Translate(Vector3.right*moveX);
#else
		float moveX = Mathf.Clamp(Input.GetAxis("Horizontal"),-1.0f, 1.0f)*speed*Time.deltaTime;
		transform.Translate(Vector3.right*moveX);
#endif
	}
	
	void OnCollisionEnter(Collision hit){
		rigidbody.AddForce(Vector3.up*force);
	}
	
	void OnBecameInvisible(){
		if(transform.position.x<Jumper_Area.min.x){
		transform.position = new Vector3(Jumper_Area.max.x, transform.position.y, transform.position.z);
		}
		if(transform.position.x>Jumper_Area.max.x){
		transform.position = new Vector3(Jumper_Area.min.x, transform.position.y, transform.position.z);
		}
}

}