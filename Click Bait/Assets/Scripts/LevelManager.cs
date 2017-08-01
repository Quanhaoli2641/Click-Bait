using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	public static float upperGrav;

	private int counter;

	public Text score;
	public Sprite dead;
	public Sprite life;
	public Image Life1;
	public Image Life2;
	public Image Life3;
	private int combo;

	public Camera gameCamera;
	public Camera gameOverCam;
	public Camera pauseCam;

	public static int clicked;

	public Image background;
	public Image shape;
	public Text highscore;
	public Image pauseButton;
	public Image replay;
	public Image quit2;

	void Start () {
		quit2.enabled = false;
		score.enabled = false;
		gameCamera.enabled = true;
		gameOverCam.enabled = false;
		pauseCam.enabled = false;
		replay.enabled = false;
		clicked = 0;
		upperGrav = 0.2f;
		combo = 0;
	}

	void Update () {
	
		counter++;
		if (counter % 120 == 0) {
			upperGrav += 0.01f;
			counter = 0;
		}

		if (clicked == 1) {
			showImage();
		} 
		else if (clicked == 2) {
			combo = 0;
			vanishImage ();
		}
		if (Life1.sprite == dead) {
			score.enabled = true;
			score.text = "" + ScoreManager.returnScore();
			gameOverCam.enabled = true;
			gameCamera.enabled = false;
			background.enabled = false;
			shape.enabled = false;
			highscore.enabled = false;
			pauseButton.enabled = false;
			replay.enabled = true;
			Life1.enabled = false;
			Life2.enabled = false;
			Life3.enabled = false;
			quit2.enabled = true;
		}
	}

	public static void updateUpper() {
		
		upperGrav += 0.01f;
		
	}

	public static float getUpper() {

		return upperGrav;

	}

	void vanishImage(){
		if (Life3.sprite == life) {
			Life3.sprite = dead;
		}
		else if(Life2.sprite == life) {
			Life2.sprite = dead;
		}
		else if(Life1.sprite == life) {
			Life1.sprite = dead;
		}
		clicked = 0;
	}
	
	void showImage(){
		combo += 1;
		if (combo == 10) {
			if (Life1.sprite == dead) {
				Life1.sprite = life;
			} else if (Life2.sprite == dead) {
				Life2.sprite = life;
			} else if (Life3.sprite == dead) {
				Life3.sprite = life;
			}
			combo = 0;
		}
		clicked = 0;
	}

	public static void modClick (int num) {
		clicked = num;
	}
	public Vector3 convertPosition (Vector3 position) {
		return gameCamera.WorldToViewportPoint(position);
	}
}
