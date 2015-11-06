using UnityEngine;
using System.Collections;

public class scr_gun_rotate_towards_mouse : MonoBehaviour {

	public Transform myPlayer;

	// Use this for initialization
	void Start () {
	
	}

	Vector3 mouse_pos;
	Transform target; //Assign to the object you want to rotate
	Vector3 object_pos;
	Vector3 myPlayerPos;
	float angle;

	// Update is called once per frame
	void Update () {
		var mouse = Input.mousePosition;
		var screenPoint = Camera.main.WorldToScreenPoint(transform.localPosition);
		var offset = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);
		var angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0, 0, angle);

		myPlayerPos = myPlayer.position;
		transform.position = myPlayerPos;
	}
}


