#pragma strict

@script RequireComponent (AudioSource)

var onlyPlayOnce : boolean = true;

private var playedOnce : boolean = false;

function OnTriggerEnter (unusedArg) {
	if (playedOnce && onlyPlayOnce)
		return;
	
	GetComponent.<AudioSource>().Play ();
	playedOnce = true;
}