using UnityEngine;
using System.Collections;

public class Jumper_Plataform : MonoBehaviour
{
	
	public int teste = 0;

	// Update is called once per frame
	void FixedUpdate ()
	{
		if (transform.position.y + teste < Camera.main.ViewportToWorldPoint (Vector3.zero).y) {
			Jumper_PlataformManager.count++;
			Destroy (gameObject);
		}
	
	}
}
