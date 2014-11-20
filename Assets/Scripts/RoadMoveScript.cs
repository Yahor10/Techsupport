using UnityEngine;
using System.Collections;

public class RoadMoveScript : MonoBehaviour {

	public float speed = 120;

	public float totalLength = 300;

	public float blockLength = 25;

	private float z;

	private float lastZ;

	void Update () {
		Vector3 currentPosition = transform.position;
		transform.position = new Vector3 (currentPosition.x, currentPosition.y, transform.position.z - speed * Time.deltaTime);
		z += transform.position.z - lastZ;
		lastZ = transform.position.z;
		if (z < -(totalLength + blockLength)) {
			Vector3 updatedPosition = transform.position;
			updatedPosition.z = -totalLength;
			transform.position = updatedPosition;
		}
	}
}
