using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {

    [Header("Set in Inspector")]
	//static variables are shared across all instances of this class.
	private static float bottomY = -15f;
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottomY) {


			//this refers to the script itself. Need to clarify the gameObject.
			Destroy (this.gameObject);

            //Get a reference to the ApplePicker component of Main Camera
           // ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            //Call the public AppleDestroyed() method of apScript
           // apScript.AppleDestroyed();
		}
	}
}
