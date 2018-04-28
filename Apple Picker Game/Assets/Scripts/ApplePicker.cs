using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour {
	[Header("Set in Inspector")]
	public GameObject healthPrefab;


	public int numHealth = 4;
	public float healthBottom = -14f;
	public float healthSpace = 2f;
    public List<GameObject> healthList;
    public GameObject tHealthGO;

	// Use this for initialization
	void Start () {
		
        healthList = new List<GameObject>();

		for (int i = 0; i < numHealth; i++) {
			GameObject health = Instantiate<GameObject> (healthPrefab);
			Vector3 pos = Vector3.zero;
			pos.y = healthBottom + (healthSpace * i) + 30;
			health.transform.position = pos;
            healthList.Add(tHealthGO);
		}

	}



 void Update () 
	{

	}

    //Declared public to be seen by other classes
    public void AppleDestroyed()
    {
        //Destroy all of the falling apples
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }
        //Get index of the last basket in basketList
        int healthIndex = healthList.Count - 1;
        //Get a reference to that Basket GameObject
        tHealthGO = healthList[healthIndex];
        //Remove the basket from list and destroy the GameObject
        healthList.RemoveAt(healthIndex);
        Destroy(tHealthGO);

        //If there is no health left, restart the game
        if (healthList.Count == 0)
        {
            SceneManager.LoadScene("Scene_2");
        }
    }
}
