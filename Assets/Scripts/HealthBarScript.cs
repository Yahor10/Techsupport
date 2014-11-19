using UnityEngine;
using System.Collections;

public class HealthBarScript : MonoBehaviour {

	public Texture backgroundTexture;
	public Texture foregroundTexture;

	public int health = 100;

	public int fullHealth = 100;

	private float timePassed = 0;

	private float fullWidth;

	public void Start () {
		fullWidth = guiTexture.pixelInset.width;
	}

	public void OnGUI () {
		timePassed += Time.deltaTime;

		if (timePassed > 1) {
			health--;
			timePassed = 0;
		}

//		GUI.DrawTexture(new Rect(marginLeft, marginTop, width, height), backgroundTexture, ScaleMode.ScaleAndCrop, true, 0);
//		GUI.DrawTexture(new Rect(marginLeft, marginTop, (width / fullHealth) * health, height), foregroundTexture, ScaleMode.ScaleAndCrop, true, 0);

		Rect inset = guiTexture.pixelInset;
		inset.width = (fullWidth / fullHealth) * health;
		guiTexture.pixelInset = inset;
	}

}