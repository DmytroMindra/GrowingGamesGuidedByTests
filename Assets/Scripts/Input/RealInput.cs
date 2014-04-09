using System.Linq;
using UnityEngine;
using System.Collections;

class RealInput : IUserInputProxy
{
	public float GetAxis (string axisName)
	{
		return Input.GetAxis (axisName);
	}

	public bool GetButton (string buttonName)
	{
		return Input.GetButton (buttonName);
	}
}

