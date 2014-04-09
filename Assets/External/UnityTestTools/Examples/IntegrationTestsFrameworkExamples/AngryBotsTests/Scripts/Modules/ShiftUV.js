#pragma strict

var offsetVector : Vector2;

function Start () {
}

function OnSignal () {
	GetComponent.<Renderer>().material.mainTextureOffset += offsetVector;
}
