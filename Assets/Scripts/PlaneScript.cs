using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    public int sceneNo;

    public void SelectPlane(string plane) {
        PlayData.Instance.planeType = plane;
        Application.LoadLevel(sceneNo);
    }
}
