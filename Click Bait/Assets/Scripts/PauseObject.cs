using UnityEngine;
using System.Collections;

public class PauseObject : MonoBehaviour {
	

	void Start () {
	
	}

	void Update () {

		if (Time.timeScale == 0) {
			this.gameObject.GetComponent<BoxCollider2D> ().enabled = false;
		} else {
			this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
		}
	
	}
}
