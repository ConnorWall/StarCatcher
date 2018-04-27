using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOne : MonoBehaviour {
//	public float time = 2; //Seconds to read the text
//
//	void Start ()
//	{     
//		Destroy(gameObject, time);
//	}

	public float lifetime = 1;
	Color fade;
	float timer;

	void Update () {

		timer += Time.deltaTime;
		if (timer >= lifetime) {
			//Transparency.
			fade = GetComponent<Renderer> ().material.color;
			fade.a = fade.a /1.1f;
			GetComponent<Renderer>().material.color = fade;
			//kill when faded
			if(fade.a <=.1){
				Destroy (transform.gameObject);
				Destroy (gameObject);
			}

		}

}
}