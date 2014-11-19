using UnityEngine;
using System.Collections;

public class RoadMoveScript : MonoBehaviour {

	public float speed = 120;

	public float totalLength = 300;

	public float blockLength = 25;

	private float z;

	private float lastZ;

	void Start () {
		rigidbody.velocity = new Vector3 (0, 0, -speed);
	}

	void Update () {
		z += transform.position.z - lastZ;
		lastZ = transform.position.z;
		if (z < -(totalLength + blockLength)) {
			Vector3 updatedPosition = transform.position;
			updatedPosition.z = -totalLength;
			transform.position = updatedPosition;
		}
	}
}
