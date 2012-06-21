using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	float speed;
	
	void Start () {
		speed = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	internal void Move(Direction d) {
		float up = 0;
		float down = 0;
		float left = 0;
		float right = 0;
		switch (d) {
		case Direction.UP : 
			up = speed;
			break;
		case Direction.DOWN : 
			down = -speed;
			break;
		case Direction.LEFT : 
			left = -speed;
			break;
		case Direction.RIGHT: 
			right = speed;
			break;
		}
		
		Vector3 p = transform.localPosition;
		p.x += left + right;
		p.y += up + down;
		transform.localPosition = p;
	}
}
