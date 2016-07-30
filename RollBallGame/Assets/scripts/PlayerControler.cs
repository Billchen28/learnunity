using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {

	public float Speed;

	Rigidbody mRb;

	void Start()
	{
		mRb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		Vector3 mov = new Vector3 (x, 0.0f, z);
		mRb.AddForce (mov * Speed);
	}

}
