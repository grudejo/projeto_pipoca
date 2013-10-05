using UnityEngine;
using System.Collections;

public class Jumper_Area : MonoBehaviour {
	
	public static Vector3 min = Vector3.zero;
	public static Vector3 max = Vector3.zero;

	// Use this for initialization
	void Awake () {
		min = camera.ScreenToWorldPoint(Vector3.zero);
		max = camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0.0f));
		}
}
