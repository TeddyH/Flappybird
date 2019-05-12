using UnityEngine;
using System.Collections;

public class PlayData {

	public string planeType;
    public bool dead;
    public int score = -1;

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
