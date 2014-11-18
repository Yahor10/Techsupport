using UnityEngine;
using System.Collections;

public class DistanceCountScript : MonoBehaviour {

	private float distance = 0;

	void Update () {
		distance += Time.deltaTime * 10;
		guiText.text = ((int) distance) + " meters";
	}
}
