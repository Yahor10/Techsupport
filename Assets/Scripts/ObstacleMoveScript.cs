using UnityEngine;
using System.Collections;

public class ObstacleMoveScript : MonoBehaviour {

    public RoadMoveScript road;

	float speed;

	public float destroyOffset = 300;

    void Start()
    {
        road = GameObject.Find("Road").GetComponent<RoadMoveScript>();
    }

	void Update () {

        speed = road.currentSpeed;
		Vector3 currentPosition = transform.position;
		transform.position = new Vector3 (currentPosition.x, currentPosition.y, transform.position.z - speed * Time.deltaTime);
		if (transform.position.z < -destroyOffset) {
			Destroy(gameObject);
		}
	}
}
