using UnityEngine;
using System.Collections;

public interface IUserInputProxy
{
	float GetAxis(string axisName);
	bool GetButton(string buttonName);
}