using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainScript : MonoBehaviour {

	// thiese global variables will be set from the inspector.
	public GameObject pipeObject;	// which prefab will represent the pipe?

	public GameObject whitePlane;	// which prefab will represent the plane?	
	public GameObject bluePlane;	
	public GameObject redPlane;

	public float pipeHole;			// how large is the gap between upper and lower pipes?

    public Text score;

	// function to be executed once the script started
	void Start () {
		// placing the bird
		Instantiate(setPlane());
		// calling "CreateObstacle" function after 0 seconds, then each 1.5 seconds, 
		InvokeRepeating("CreateObstacle", 0f, 1.5f);
    }

	// function called by InvokeRepeating function
	void CreateObstacle(){
		// generating random upper pipe position
		float randomPos = 4f-(4f-0.8f-pipeHole)*Random.value;
		// adding upper pipe to stage
		GameObject upperPipe = Instantiate(pipeObject);
		// setting upper pipe position
		upperPipe.transform.position = new Vector2(4f,randomPos);
		// adding lower pipe to stage
		GameObject lowerPipe = Instantiate(pipeObject);
		// setting lower pipe position
		lowerPipe.transform.position = new Vector2(4f,randomPos-pipeHole-4.8f);

        if(PlayData.Instance.dead == false) {
            PlayData.Instance.score++;
            SetScore();
        }
	}

    void SetScore() {    
        score.text = PlayData.Instance.score.ToString();
    }

	GameObject setPlane() {
		string plane = PlayData.Instance.planeType;
		GameObject retPlane = whitePlane;
        Debug.Log("retPlane: " + plane);

		if (plane.Equals ("white")) {
            retPlane = whitePlane;
		} else if (plane.Equals ("blue")) {
            retPlane = bluePlane;
		} else if (plane.Equals ("red")) {
            retPlane = redPlane;
		}
        
        return retPlane;
	}
    
}