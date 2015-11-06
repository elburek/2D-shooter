using UnityEngine;
using System.Collections;

public class scr_player_movement : MonoBehaviour {
	
	public float Speed = 5f;
	public float timer = 0.5f;
	private float movex = 0f;
	private float movey = 0f;
	
	void FixedUpdate () {

		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");

		if (timer > 0) {
			timer -= Time.deltaTime;
			movex *= 5;
			movey *= 5;
		} 

		Vector3 pos = transform.position;
		if (pos.y > Camera.main.orthographicSize) {
			pos.y = Camera.main.orthographicSize;
		}

		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * Speed);
	}
	
	void Update(){
	if (Input.GetKeyDown ("space")){
		timer = 0.1f;
	}

	}
}