using UnityEngine;
using System.Collections;

public class AccuShip : MonoBehaviour {

	void Update () {
		var speed = 4;
		this.gameObject.transform.Translate (0, speed * Time.deltaTime, 0);
	}
}
