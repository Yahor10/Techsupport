using UnityEngine;
using System.Collections;

public class HealthBarScript : MonoBehaviour {

	public Texture backgroundTexture;
	public Texture foregroundTexture;

	public int health = 100;

	public int fullHealth = 100;

	public int width = 100;
	public int height = 10;

	public int marginLeft = 260;
	public int marginTop = 80;

	private float timePassed = 0;

	public void OnGUI () {
		timePassed += Time.deltaTime;

		if (timePassed > 1) {
			health--;
			timePassed = 0;
		}

//		GUI.DrawTexture(new Rect(marginLeft, marginTop, width, height), backgroundTexture, ScaleMode.ScaleAndCrop, true, 0);
		GUI.DrawTexture(new Rect(marginLeft, marginTop, (width / fullHealth) * health, height), foregroundTexture, ScaleMode.ScaleAndCrop, true, 0);
	}

}