using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelOne : MonoBehaviour {
//	public float time = 2; //Seconds to read the text
//
//	void Start ()
//	{     
//		Destroy(gameObject, time);
//	}

	public float lifetime = 1;
	float timer;

	void Update () {

		timer += Time.deltaTime;
		if (timer >= lifetime) {

				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			}

		}
	

}
