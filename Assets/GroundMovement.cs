using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour {
    Rigidbody2D robot;
    float xAxis;

	// Use this for initialization
	void Start () {
        robot = GetComponent<Rigidbody2D>();
   
    }
	
	// Update is called once per frame
	void Update () {
        xAxis = Input.GetAxisRaw("Horizontal");

        //Keep in mind if you want custom movement controls you can always do things like this:

        //left = Input.GetKeyDown(KeyCode."Insert Your Key Here");
        //and then follow it up with other lines 

        //or something like this:

        //bool movingRight = false;
        //if (Input.GetKeyDown(KeyCode."Insert Button Here")):
        //      movingRight = true;
        //else:
        //      movingRight = false;
        //if (movingRight) {
        //    do stuff  
        //  }

        move1();     
    }

    void move1() {
        Vector2 movement = new Vector2(xAxis, 0);
        robot.AddForce(movement);
    }

    void move2() {
        //use Mathf.Clamp()
        Vector2 movement = new Vector2(xAxis, 0);
        movement = movement * 150;
        robot.AddForce(movement);
        robot.velocity = new Vector2(Mathf.Clamp(robot.velocity.x, 0, 3), robot.velocity.y);
    }

    void move3() {
        //Make a movement function that instantaneously moves the robot right when "D" is pressed, and 
        //instantaneously moves the robot left when "A" is pressed. Robot should immediately stop if no 
        //button is pressed. 
    }

    void translate1() {
        Vector2 movement = new Vector2(xAxis, 0);
        robot.MovePosition(robot.position + movement);
    }
}
