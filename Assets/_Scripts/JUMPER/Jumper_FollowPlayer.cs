using UnityEngine;
using System.Collections;

public class Jumper_FollowPlayer : MonoBehaviour {

	private Transform target;
	
	
	
	// Use this for initialization
	void Start () {
		target = GameObject.Find("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		
		if(target.position.y>transform.position.y){
		position = new Vector3(transform.position.x, target.position.y, transform.position.z);
		}
		
	transform.position = position;
	}
}
