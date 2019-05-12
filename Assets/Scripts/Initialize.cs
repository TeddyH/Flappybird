using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Initialize : MonoBehaviour {
	// Use this for initialization
	void Start () {
		//Set Game Config
		Screen.SetResolution(800, 480, true);

		PlayData.Instance.planeType = "white";
        Debug.Log(PlayData.Instance.planeType);

		Debug.Log ("HasPlayed : " + PlayerPrefs.GetInt ("HasPlayed"));

		if (PlayerPrefs.GetInt ("HasPlayed") == 0) {

			PlayerPrefs.SetInt("HasPlayed", 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
