using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody))]

public class Jumper_Player : MonoBehaviour
{
	
	public float force = 800.0f;
	public float speed = 200.0f;
	private RaycastHit hit;
	public float distance = 1.0f;

	// Use this for initialization
	
	void Start ()
	{
		rigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
#if UNITY_ANDROID
		
		float moveX = Mathf.Clamp (Input.acceleration.x, -2.0f, 2.0f)*speed*Time.deltaTime;
		rigidbody.velocity = new Vector3(moveX, rigidbody.body.y, 0.0f);
#else
		float moveX = Mathf.Clamp (Input.GetAxis ("Horizontal"), -2.0f, 2.0f) * speed * Time.deltaTime;
		rigidbody.velocity = new Vector3 (moveX, rigidbody.velocity.y, 0.0f);
#endif
		
		Debug.DrawRay (transform.position, -Vector3.up * distance, Color.magenta);
	
		if (rigidbody.velocity.y < 0) {
			if (Physics.Raycast (transform.position, -Vector3.up, out hit, distance)) {
			
				Physics.IgnoreLayerCollision (LayerMask.NameToLayer ("Player"), LayerMask.NameToLayer ("Plataform"), false);
				Debug.DrawLine (transform.position, hit.point, Color.green);
			}

	
		}
	
	
	}
	
	void OnCollisionEnter (Collision hit)
	{
		rigidbody.AddForce (Vector3.up * force);
		Physics.IgnoreLayerCollision (LayerMask.NameToLayer ("Player"), LayerMask.NameToLayer ("Plataform"), true);
	}
	
	void OnBecameInvisible ()
	{
		if (transform.position.x < Jumper_Area.min.x) {
			transform.position = new Vector3 (Jumper_Area.max.x, transform.position.y, transform.position.z);
		}
		if (transform.position.x > Jumper_Area.max.x) {
			transform.position = new Vector3 (Jumper_Area.min.x, transform.position.y, transform.position.z);
		}
	}

}