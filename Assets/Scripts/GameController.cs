using System.Linq;
using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject Spaceship;
	public AlienShip AlienShip;
	public float AlienSpawnRate;
	public float AlienSpeed;

	float nextSpawnTime;

	void Start()
	{
		InitializeUserInput ();

	}

	// Update is called once per frame
	void Update () {

		if (Time.time > nextSpawnTime)
						SpawnAlien ();
	}

	void InitializeUserInput ()
	{
		IUserInputProxy input = new RealInput ();
		var components = Spaceship.GetComponents<MonoBehaviour> ().Where (c => c is IRequireUserInput).Cast<IRequireUserInput> ();
		foreach (var component in components)
			component.InputProxy = input;
	}

	void SpawnAlien()
	{
		nextSpawnTime = Time.time + 1f / AlienSpawnRate;
		var alien = Instantiate (AlienShip, new Vector3 (Random.Range (-4f, 4f), 10, 0), Quaternion.identity) as AlienShip;
		alien.Speed = AlienSpeed;
	}

}
