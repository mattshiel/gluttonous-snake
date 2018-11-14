using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour {

    public float speed = 10.0f;
    private Rigidbody2D rigidBody;


    // Use this for initialization
    void Start () {
        // No need to check if the component exists as RequireComponent ensures it must exist
        rigidBody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        //Get the new position of our player
        var x = transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var y = transform.position.y + Input.GetAxis("Vertical") * Time.deltaTime * speed;

        // Move the player to a new position
        rigidBody.MovePosition(new Vector2(x, y));
    }
}
