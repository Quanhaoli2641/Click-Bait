using UnityEngine;
using System.Collections;

public class ClickButton : MonoBehaviour {
	private LevelManager lm;
	private bool once;
	Vector3 screenPoint;
	bool onScreen;

	void Start () {
		lm = FindObjectOfType<LevelManager> ();
		once = false;
	}


	void Update () {
		screenPoint = lm.convertPosition (this.transform.position);
		onScreen = screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;
		if (onScreen && !once) {
			once = true;
		}
		if (!onScreen && once) {
			if ((this.gameObject.tag == RandomObject.getSprite ().tag) || (this.gameObject.layer == RandomObject.getSprite ().layer)) {
				if (!((this.gameObject.tag == RandomObject.getSprite ().tag) && (this.gameObject.layer == RandomObject.getSprite ().layer))){
					LevelManager.modClick(2);
					once = false;
				}
			}
		}

	}

	void OnMouseDown() {
		Debug.Log (this.gameObject.tag);
		if ((this.gameObject.tag == RandomObject.getSprite ().tag) || (this.gameObject.layer == RandomObject.getSprite ().layer)) {
			if (!((this.gameObject.tag == RandomObject.getSprite ().tag) && (this.gameObject.layer == RandomObject.getSprite ().layer))){
				LevelManager.modClick (1);
				ScoreManager.updateScore();
			} else {
				LevelManager.modClick (2);
			}
		} else {
			LevelManager.modClick(2); 
		}
		Destroy(gameObject);
	}
}
