using UnityEngine;
using System.Collections;

public class PlayData {

	public string cubeColor;

	// Singleton 패턴
	static PlayData _instance;
	public static PlayData Instance {
		get {
			if(_instance == null)
			{
				_instance = new PlayData ();
			}
			return _instance; 
		}
	}
}
