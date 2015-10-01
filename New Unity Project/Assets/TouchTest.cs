using UnityEngine;
using System.Collections;

public class TouchTest : MonoBehaviour {

	public Texture2D touchTexture;

	// Update is called once per frame
	void OnGUI () {
		Touch[] touches = Input.touches;
		Debug.developerConsoleVisible = true;
		Debug.LogError ("TOUCHES: " + touches.Length);
		for(int i = 0; i < touches.Length; i++) {
			Vector2 pos = new Vector2(touches[i].position.x - 32f, Screen.height - touches[i].position.y - 32f);
			GUI.DrawTexture(new Rect(pos, Vector2.one * 64f), touchTexture);
			GUI.Label(new Rect(pos + Vector2.up * 42f, new Vector2(100f, 30f)), "Finger ID: " + touches[i].fingerId);
			GUI.Label(new Rect(pos + Vector2.up * 82f, new Vector2(100f, 30f)), "X: " + touches[i].position.x + " Y: " + touches[i].position.y);
		}
	}
}
