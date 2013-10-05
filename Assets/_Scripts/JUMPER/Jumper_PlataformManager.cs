using UnityEngine;
using System.Collections;

public class Jumper_PlataformManager : MonoBehaviour {

	public Transform[] plataform;
	
	private float height=0.0f;
	private float width;
	private int minStep=3;
	private int maxStep=8;
	
	public static int count=10;
	
	// Use this for initialization
	void Start () {
		width = Camera.main.ViewportToWorldPoint(Vector3.one).x *0.5f;
		CreatePlataform();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		CreatePlataform();
	}
	
	void CreatePlataform(){
		while(count>0){
			Vector3 direction = new Vector3(Random.Range (-1000,1000), Random.Range (500,1000), 0.0f);
			direction.Normalize();
			height += direction.y * Random.Range (minStep, maxStep);
			float posX = direction.x * Random.Range (minStep, maxStep);
			
			Instantiate(plataform[Random.Range(0, plataform.Length)], new Vector3(posX, height, 0.0f), Quaternion.identity);
			count--;
		}
	}
}
