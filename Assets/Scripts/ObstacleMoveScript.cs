using UnityEngine;
using System.Collections;

public class ObstacleMoveScript : MonoBehaviour {

	public float speed = 120;

	public float destroyOffset = 300;

	void Update () {
		Vector3 currentPosition = transform.position;
		transform.position = new Vector3 (currentPosition.x, currentPosition.y, transform.position.z - speed * Time.deltaTime);
		if (transform.position.z < -destroyOffset) {
			Destroy(gameObject);
		}
	}
}
