using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	private static int score;
	private static int highScore;
	Text text;

	void Start () {
		score = 0;
		text = GetComponent<Text> ();
	}
	
	void Update () {
		text.text = "" + score;
	}

	public static void updateScore(){
		score += 1;
	}

	public static int returnScore(){
		return score;
	}
}
