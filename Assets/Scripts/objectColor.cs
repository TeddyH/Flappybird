using UnityEngine;
using System.Collections;

public class objectColor : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		string color = PlayData.Instance.cubeColor;

		if (color == null) {
			gameObject.GetComponent<Renderer> ().materials [0].color = Color.yellow;
		} else if (color.Equals ("red")) {
			gameObject.GetComponent<Renderer> ().materials [0].color = Color.red;
		} else if (color.Equals ("black")) {
			gameObject.GetComponent<Renderer> ().materials [0].color = Color.black;
		}
	}
}
