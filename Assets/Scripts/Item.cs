using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter (Collider c) {
		if (c.gameObject.name.Contains("PacMan")) {
			CollidedWithPlayer();
		}
	}
	
	void CollidedWithPlayer(){}
}
