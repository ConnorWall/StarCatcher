using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//enables use uGUI features
using UnityEngine.UI; 




public class Basket : MonoBehaviour {
    [Header("Set Dynamically")]
    public Text scoreGT;




   

    private void Start()
    {
        //Find a reference to the ScoreCounter GameObject
        //searches through all the gameobjects in the scene to be assigned to a local variable
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        //Get the Text Commponent of that GameObject
        scoreGT = scoreGO.GetComponent<Text>();
        //Set the starting number of points to 0
        scoreGT.text = "0";
       
    }

    // Update is called once per frame
    void Update () {
		//gets current screen position of the mouse from Input. z-value defaults to 0.
		Vector3 mousePos2D = Input.mousePosition;

		//the camera's z position sets how far to psh the mouse into 3D. Prepping for conversion from 2D 3D position.
		mousePos2D.z = -Camera.main.transform.position.z;

		//converts the point from 2D screen space into 3D space.
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

		//moves the x position of the Basket to this x position of the mouse.
		Vector3 pos = this.transform.position;
		pos.x = mousePos3D.x ;
		this.transform.position = pos;
	}

	//activates when another gameObject collides with this basket. A collision argument with information on the collision is passed into the function.
	void OnCollisionEnter(Collision coll) {
		//finds out what hit this basket.
		GameObject collidedWith = coll.gameObject;
		
        if (collidedWith.tag == "Star")
        {
            
            Destroy(collidedWith);
            //Parse the text of the scoreGT into an int
            int score = int.Parse(scoreGT.text);
            //Add points for catching an apple
            score += 50;
            //Convert the score back to a string and display it
            scoreGT.text = score.ToString();

			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();

           
        }
		if (collidedWith.tag == "Earth")
		{
			Destroy(collidedWith);
			//Parse the text of the scoreGT into an int
			int score = int.Parse(scoreGT.text);
			//Add points for catching an apple
			score += 30;
			//Convert the score back to a string and display it
			scoreGT.text = score.ToString();
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();


		}
		if (collidedWith.tag == "Jupiter")
		{
			Destroy(collidedWith);
			//Parse the text of the scoreGT into an int
			int score = int.Parse(scoreGT.text);
			//Add points for catching an apple
			score += 20;
			//Convert the score back to a string and display it
			scoreGT.text = score.ToString();
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();


		}
		if (collidedWith.tag == "Saturn")
		{
			Destroy(collidedWith);
			//Parse the text of the scoreGT into an int
			int score = int.Parse(scoreGT.text);
			//Add points for catching an apple
			score += 20;
			//Convert the score back to a string and display it
			scoreGT.text = score.ToString();
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();


		}
		if (collidedWith.tag == "Astroid")
		{
			Destroy(collidedWith);
			//Parse the text of the scoreGT into an int
			int score = int.Parse(scoreGT.text);
			//Add points for catching an apple
			score -= 20;
			//Convert the score back to a string and display it
			scoreGT.text = score.ToString();

			AudioSource audio = GetComponent<AudioSource>();
		
			audio.Play();


		}
		if (collidedWith.tag == "Alien")
		{
			Destroy(collidedWith);
			//Parse the text of the scoreGT into an int
			int score = int.Parse(scoreGT.text);
			//Add points for catching an apple
			score -= 50;
			//Convert the score back to a string and display it
			scoreGT.text = score.ToString();
			AudioSource audio = GetComponent<AudioSource>();
	
			audio.Play();

		}

       if (collidedWith.tag == "Black Hole")
        {
            Destroy(collidedWith);
            //Parse the text of the scoreGT into an int
            int score = int.Parse(scoreGT.text);
            //Add points for catching an apple
            score -= 100;
            //Convert the score back to a string and display it
            scoreGT.text = score.ToString();
			AudioSource audio = GetComponent<AudioSource>();
		
			audio.Play();

        }
    }
}
