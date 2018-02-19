using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    public float ballSpeed = 500;

    Rigidbody ballRB;
    bool inPlay;
    int randDirection; 

	// Use this for initialization
    // Awake initializes for every ball object whereas
    // start initializes only at the beginning of the scene
	void Awake () {
        ballRB = gameObject.GetComponent<Rigidbody> ();
        randDirection = Random.Range(1,3);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0) == true && inPlay == false)
        {
            transform.parent = null; // this detaches the ball from the paddle
            inPlay = true;
            ballRB.isKinematic = false;

            // If the direction is equal to 1, then send ball to top right corner
            if (randDirection == 1)
            {
                ballRB.AddForce(new Vector3(ballSpeed, ballSpeed, 0));
            // If the direction is equal to 2, then send ball to bottom left corner
            } else {
                ballRB.AddForce(new Vector3(ballSpeed, -ballSpeed, 0));
            }
        }
	}
}
