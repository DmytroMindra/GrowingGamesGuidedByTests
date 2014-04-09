using System;
using UnityEngine;
using System.Collections;

public class LaserBullet : MonoBehaviour {

	public float Range;
	public float Speed;

	// Update is called once per frame
	void Update () {

		// Move ();
		// CheckRange ();

	}


	// to move the bullet we calculate dY
	// float deltaY = Speed * Time.deltaTime;
	// this.transform.Translate (0, deltaY, 0);

	void Move ()
	{
		throw new NotImplementedException();
	}


	// ah and when the object has left our warzone let's destroy it
	// if (this.transform.position.y > Range)
	// Destroy (this.gameObject);

	void CheckRange(){
		throw new NotImplementedException();
	}
}
