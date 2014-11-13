using UnityEngine;
using System.Collections;

public class RoadMoveScript : MonoBehaviour {

	private float z;

	private float lastZ;

	private Hashtable roadSegments = new Hashtable();

	void Start () {
		rigidbody.velocity = new Vector3 (0, 0, -120);
//		GameObject[] gameObjects = FindObjectsOfType<GameObject> ();
//		foreach (GameObject tempObject in gameObjects) {
//			if (tempObject.name.Contains("Segment")) {
//				roadSegments.Add (tempObject.transform.position.z, tempObject);
//				print (tempObject.name);
//			}
//		}
	}

	void Update () {
		z += transform.position.z - lastZ;
		lastZ = transform.position.z;
		if (z < -325) {
			transform.position = new Vector3 (0, 152, -301);
		}
	}
}
