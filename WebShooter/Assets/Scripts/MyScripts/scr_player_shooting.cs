using UnityEngine;
using System.Collections;

public class scr_player_shooting : MonoBehaviour {

	public GameObject bulletPrefab;
	public string layerName;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject createdBullet = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
			createdBullet.layer = LayerMask.NameToLayer(layerName);
		}
	}
}
