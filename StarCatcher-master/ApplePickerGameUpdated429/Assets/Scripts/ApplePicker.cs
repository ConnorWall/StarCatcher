using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{

   /* GAMEOVER
    
    private float endGameCounter;

    void FixedUpdate()
    {
        endGameCounter++;
        if (endGameCounter % enter number of seconds here == 0)
        {
            do stuff
        }
    }
    */

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
