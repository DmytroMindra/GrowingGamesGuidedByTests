using System.Linq;
using UnityEngine;
using System.Collections;

public class ArrangeFakeUserInput : MonoBehaviour {

	public GameObject Spaceship;

	public FakeUserInput FakeInput;

	void Start () {

		var components = Spaceship.GetComponents<MonoBehaviour>().Where(c=>c is IRequireUserInput).Cast<IRequireUserInput>();

		foreach(var component in components)
			component.InputProxy = FakeInput;
	}

}
