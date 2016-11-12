
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float moveVertical2 = Input.GetAxis ("Vertical2");

		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, moveVertical2);

		rb.AddForce (movement * speed);
	}
}