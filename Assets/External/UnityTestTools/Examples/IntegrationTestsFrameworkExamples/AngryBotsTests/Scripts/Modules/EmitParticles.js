#pragma strict

function OnSignal () 
{
	GetComponent.<ParticleEmitter>().emit = true;
}