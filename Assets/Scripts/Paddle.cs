using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour 
{

	public float paddleSpeed = 0.5f;



	private Vector3 playerPosition = new Vector3 (0f, -9.5f, 0f);
	

	// Update is called once per frame
	void Update () 
	{
		float xPos = transform.position.x + Input.GetAxis ("Horizontal") * paddleSpeed;
		playerPosition = new Vector3 (Mathf.Clamp (xPos, -8f, 8f), -9.5f, 0f);
		transform.position = playerPosition;
	}
}
