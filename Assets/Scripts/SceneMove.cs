using UnityEngine;
using System.Collections;

public class SceneMove : MonoBehaviour {

	public int sceneNo;

	public void move() {
		Application.LoadLevel (sceneNo);
	}
}
