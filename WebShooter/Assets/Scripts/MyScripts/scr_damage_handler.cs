using UnityEngine;
using System.Collections;

public class scr_damage_handler : MonoBehaviour {

	public int health;

	void OnTriggerEnter2D(){
		Debug.Log ("Trigger!");
		health--;
	}

	// Update is called once per frame
	void Update () {
		if (health <= 0)
			Destroy (gameObject);
	}
}
