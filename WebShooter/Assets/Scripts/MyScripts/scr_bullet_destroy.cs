using UnityEngine;
using System.Collections;

public class scr_bullet_destroy : MonoBehaviour {

	public float lifetime = 1f;
	
	void Update () {
		lifetime -= Time.deltaTime;
		if (lifetime <= 0)
			Destroy (gameObject);
	}
}
