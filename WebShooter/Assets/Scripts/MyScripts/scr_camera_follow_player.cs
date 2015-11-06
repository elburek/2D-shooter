using UnityEngine;
using System.Collections;

public class scr_camera_follow_player : MonoBehaviour {
	public Transform myTarget;
	public float speed = 0.5F;
	private float startTime;
	private float journeyLength;
	
	
	// Use this for initialization
	void Start () {
		startTime = Time.time;
		journeyLength = Vector3.Distance(transform.position, myTarget.position);
	}
	
	// Update is called once per frame
	void Update () {
		if (myTarget != null) {
			Vector3 targPos = myTarget.position;
			targPos.z = transform.position.z;
			
			float distCovered = (Time.time - startTime) * speed;
			float fracJourney = distCovered / journeyLength;
			
			transform.position = Vector3.Lerp(transform.position, targPos, fracJourney);
		}
		
	}
}