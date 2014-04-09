using UnityEngine;
using System.Collections;

public class ExplosionCounter : MonoBehaviour {

	public int Explosions;
	public GameObject Container;

	void Update () {
		Explosions = Container.GetComponentsInChildren<Explosion> ().Length;		
	}
}
