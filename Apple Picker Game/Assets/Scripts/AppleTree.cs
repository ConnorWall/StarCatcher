using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {

	[Header("Set in Inspector")]


	//instantiates Apples.
	public GameObject applePrefab; 

	//speed of the AppleTree moves.
	public float speed = 1f; 

	//distance where the AppleTree turns around.
	public float treeBorders = 10f; 

	//chance that the AppleTree will change change directions.
	public float randomMove = 0.1f; 

	//rate at which Apples will be instantiated.
	public float appleInterval = 1f; 

	// Use this for initialization
	void Start () {
		//drops apples every second. The second parameter is for delay in seconds.
		Invoke("DropApple", 2f);
	}
	
	// Update is called once per frame, dependent on computer performance
	void Update () {
		//Basic Movement
		Vector3 pos = transform.position;

		//deltaTime is a measure of the number seconds since the last frame. Makes movement time based, not framerate based.
		pos.x += speed * Time.deltaTime;

		//assigns modified pos variable to the transform component.
		transform.position = pos; 

		//Changing Direction
		if (pos.x < -treeBorders) {
			//move right.
			speed = Mathf.Abs (speed);
		} else if (pos.x > treeBorders) {
			//move left.
			speed = -Mathf.Abs (speed);
		} 

	}

	void FixedUpdate() {
		//every second a 2% chance exists that the AppleTree will change directions.
		if (Random.value < randomMove) {
			//changes direction.
			speed *= -1;
		}
	}

	void DropApple() {
		GameObject apple = Instantiate<GameObject> (applePrefab);

		//the position of apple is set to the position of the AppleTree.
		apple.transform.position = transform.position;

		//function invokes itself with the specified delay. A loop!
		Invoke ("DropApple", appleInterval);
	}
}
