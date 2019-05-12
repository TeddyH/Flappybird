using UnityEngine;
using System.Collections;

public class SceneMove : MonoBehaviour {

	public int sceneNo;

	public void move() {
        initializeValues();
		Application.LoadLevel (sceneNo);
	}

    public void initializeValues() {
        PlayData.Instance.dead = false;
        PlayData.Instance.score = -1;
    }
}
