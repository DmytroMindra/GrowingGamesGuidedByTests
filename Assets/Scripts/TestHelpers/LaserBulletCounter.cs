using UnityEngine;
using System.Collections;

public class LaserBulletCounter : MonoBehaviour {

	public GameObject BulletContainer;
	public int Bullets;

	// Update is called once per frame
	void Update () {

		Bullets = BulletContainer.GetComponentsInChildren<LaserBullet> ().Length;
	}
}
