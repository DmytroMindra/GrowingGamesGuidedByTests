using UnityEngine;
using System.Collections;


[RequireComponent (typeof (Rigidbody))]
public class Eject : MonoBehaviour
{
	public Vector3 force, torque;


	void Start ()
	{
		GetComponent<Rigidbody>().useGravity = true;
		GetComponent<Rigidbody>().AddForce (force);
		GetComponent<Rigidbody>().AddTorque (torque);
	}
	
	
	void OnDrawGizmos ()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawLine (transform.position, transform.position + force.normalized);
	}
}
