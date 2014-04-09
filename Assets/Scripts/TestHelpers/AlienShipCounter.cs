using UnityEngine;
using System.Collections;

public class AlienShipCounter : MonoBehaviour {

	public GameObject Container;
	public int AlienShips;

	// Update is called once per frame
	void Update () {
		AlienShips = Container.GetComponentsInChildren<AlienShip> ().Length;		
	}
}
