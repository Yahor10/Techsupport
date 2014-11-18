using UnityEngine;
using System.Collections;

public class ObstacleMoveScript : MonoBehaviour {

	public float speed = 120;

	public float destroyOffset = 300;

	void Start () {
		rigidbody.velocity = new Vector3 (0, 0, -speed);
	}

	void Update () {
		if (transform.position.z < -destroyOffset) {
			Destroy(gameObject);
		}
	}
}
