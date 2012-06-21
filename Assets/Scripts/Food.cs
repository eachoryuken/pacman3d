using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {

	IEnumerator OnTriggerEnter (Collider c) {
		Debug.Log("COLIDIU!\n"+c);
		if (c.gameObject.CompareTag("Player")) {
			CollidedWithPlayer();
		}
		return null;
	}
	
	void CollidedWithPlayer () {
		Debug.Log("Point!!!");
		Destroy(gameObject);
	}
}
