using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{

    //GAMEOVER
    
    private float endGameCounter;

    void FixedUpdate()
    {
        endGameCounter++;
        if (endGameCounter % 1000 == 0)
        {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
        }
    }
    

    //Declared public to be seen by other classes
    public void StarDestroyed()
    {
        //Destroy all of the falling apples
        GameObject[] starArray = GameObject.FindGameObjectsWithTag("Star");
        foreach (GameObject tGO in starArray)
        {
            Destroy(tGO);
        }
    }
}
