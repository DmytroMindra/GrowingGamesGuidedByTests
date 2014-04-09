
var explPrefab : GameObject;

function OnTriggerEnter(other : Collider) {
	if(other.GetComponent.<Collider>().tag == "Player") {
		var go : GameObject = Instantiate(explPrefab, transform.position, transform.rotation);	
	}	
}