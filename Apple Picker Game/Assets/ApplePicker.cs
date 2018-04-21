using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour {
	[Header("Set in Inspector")]
	public GameObject basketPrefab;
	public int numBaskets = 3;
	public float basketBottom = -14f;
	public float basketSpace = 2f;
    public List<GameObject> basketList;
    public GameObject tBasketGO;

	// Use this for initialization
	void Start () {
        basketList = new List<GameObject>();

		for (int i = 0; i < numBaskets; i++) {
			GameObject basket = Instantiate<GameObject> (basketPrefab);
			Vector3 pos = Vector3.zero;
			pos.y = basketBottom + (basketSpace * i) + 30;
			basket.transform.position = pos;
            basketList.Add(tBasketGO);
		}
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
        int basketIndex = basketList.Count - 1;
        //Get a reference to that Basket GameObject
        tBasketGO = basketList[basketIndex];
        //Remove the basket from list and destroy the GameObject
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);

        //If there are no baskets left, restart the game
        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("Scene_0");
        }
    }
}
