using UnityEngine;
using System.Collections;

public class purchase : MonoBehaviour {

	public void purchaseColor(string color) {
		PlayData.Instance.planeType = color;
	}
}
