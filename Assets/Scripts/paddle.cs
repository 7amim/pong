using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour {

    public float paddleSpeed = 1;
    public Vector3 playerPos;
    float yPos;

    /* Use this for initialization
    void Start () {
        paddleSpeed = 1;
	}*/
	
	// Update is called once per frame
	void Update () {
        yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * paddleSpeed);
        playerPos = new Vector3(-15, Mathf.Clamp(yPos, -8, 8), 0);
        gameObject.transform.position = playerPos; 
	}
}
