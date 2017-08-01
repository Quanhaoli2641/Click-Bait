using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PausePause : MonoBehaviour {

	public Camera mc;
	public Camera pausec;
	
	public Image background;
	public Image shape;
	public Text highscore;
	public Image pauseButton;
	public Image life1;
	public Image life2;
	public Image life3;
	public Image pausePause;
	public Image quit;
	
	// Use this for initialization
	void Start () {
		/*mc.enabled = true;
		pausec.enabled = false;
		background.enabled = true;
		shape.enabled = true;
		highscore.enabled = true;
		pauseButton.enabled = true;
		life1.enabled = true;
		life2.enabled = true;
		life3.enabled = true;
		pausePause.enabled = false;*/
		
	}

	void Update () {
		
	}
	
	public void pause() {
		Time.timeScale = 1.0f;
		mc.enabled = true;
		pausec.enabled = false;
		background.enabled = true;
		shape.enabled = true;
		highscore.enabled = true;
		pauseButton.enabled = true;
		life1.enabled = true;
		life2.enabled = true;
		life3.enabled = true;
		pausePause.enabled = false;
		quit.enabled = false;
	}
}
