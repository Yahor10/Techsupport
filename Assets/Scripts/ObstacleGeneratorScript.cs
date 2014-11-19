using UnityEngine;
using System.Collections;

public class ObstacleGeneratorScript : MonoBehaviour {

	public Transform obstaclePrefab;

	public float[] positions = new float[] {-10, 0, 10};

	private double timePassed = 0;

	void Start () {
	
	}

	void Update () {
		timePassed += Time.deltaTime;
		if (timePassed > 1) {
			Transform obstacle = Instantiate(obstaclePrefab) as Transform;
			obstacle.position = new Vector3 (positions[Random.Range(0, 3)], 4, 600);
			timePassed = 0;
		}
	}
}
