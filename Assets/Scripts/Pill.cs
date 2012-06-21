using UnityEngine;
using System.Collections;

public class Pill : MonoBehaviour {

	IEnumerator OnTriggerEnter (Collider c) {
		Debug.Log("COLIDIU!\n"+c);
		if (c.gameObject.CompareTag("Player")) {
			CollidedWithPlayer();
		}
		return null;
	}
	
	void CollidedWithPlayer () {
		Debug.Log("SuperPower!!!");
		Destroy(gameObject);
	}
}
