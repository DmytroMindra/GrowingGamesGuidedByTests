
#pragma strict

var clip : String = "MyAnimation";

function OnSignal () {
	GetComponent.<Animation>().Play(clip);
}