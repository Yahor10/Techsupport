using UnityEngine;
using System.Collections;

public class ObstacleMoveScript : MonoBehaviour {

	public float speed = 120;

	void Start () {
		rigidbody.velocity = new Vector3 (0, 0, -speed);
	}

	void Update () {
	
	}
}
