using UnityEngine;
using System;
using System.Collections;

public class SpaceshipGun : MonoBehaviour, IRequireUserInput {

	public IUserInputProxy InputProxy { get; set;}
	public GameObject GunMuzzle;
	public LaserBullet Bullet;
	public float BulletSpeed;
	public float BulletRange;
	public float ShotsPerSecond;

	private float NextShot;

	// Update is called once per frame
	// If this component is responsible for shooting then
	// Shoot (); 
	void Update () {

	}

	// Shooting is actually just an instantiation and initialization of bullets

	// var bullet = Instantiate (Bullet, GunMuzzle.transform.position, Quaternion.identity) as LaserBullet;
	// bullet.transform.parent = this.transform.parent;
	// bullet.Speed = BulletSpeed;
	// bullet.Range = BulletRange;

	// Don't forget to set the interval for next shot
	// NextShot = Time.time + 1f / ShotsPerSecond;

	void Shoot ()
	{
		throw new NotImplementedException();
	}

	// the ship can shoot if
	// InputProxy != null &&
	// InputProxy.GetButton ("Fire1") &&
	// ItsTimeToShoot ()

	bool CanShoot ()
	{
		throw new NotImplementedException();
	}

	// It's time to shoot if Time.time > NextShot
	bool ItsTimeToShoot ()
	{
		throw new NotImplementedException();
	}
}
