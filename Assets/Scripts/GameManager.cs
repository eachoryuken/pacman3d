using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	protected GameManager instance;
	public GameManager Instance {
		get {
			return instance;
		}
	}
	void Awake () {
		instance = this;
	}
	
	protected Player player;
	
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	// Update is called once per frame
	void Update () {
		HandlePlayerInput();
	}
	
	void HandlePlayerInput () {
		Direction d = Direction.NONE;
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
			d = Direction.UP;
		}
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
			d = Direction.LEFT;
		}
		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
			d = Direction.DOWN;
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			d = Direction.RIGHT;
		}
		player.Move(d);
	}
}
