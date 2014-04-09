using System;
using UnityEngine;
using System.Collections;

[Serializable]
public class FakeUserInput : IUserInputProxy {

	public float Horizontal;
	public float Vertical;
	public bool Fire1;


	public float GetAxis(string axisName)
	{
		float value;
		switch (axisName) 
		{
			case "Horizontal": value = Horizontal; break;
			case "Vertical": value = Vertical; break;
				default: throw new ArgumentException("Invalid axis");
		}
		return value;
	}

	public bool GetButton(string buttonName)
	{
		if (buttonName == "Fire1")
						return Fire1;
		throw new ArgumentException("Invalid button name");
	}

}
