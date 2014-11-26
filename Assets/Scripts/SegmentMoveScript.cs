using UnityEngine;
using System.Collections;

public class SegmentMoveScript : MonoBehaviour {

	public float speed = 120;

	public float startZ = 475;

	public float endZ = -25;

	void Update () {
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - speed * Time.deltaTime);
		if (transform.position.z <= endZ) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, startZ);
		}
	}
}
