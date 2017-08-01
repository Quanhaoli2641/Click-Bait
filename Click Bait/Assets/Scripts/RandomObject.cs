using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomObject : MonoBehaviour {

	public GameObject[] sprites;

	private int rand;
	private int counter;
	private int rate;

	private static GameObject current;

	void Start () {
		rand = (int)Random.Range (0.0F, 24.0F);
		if (rand == 24) { 
			rand = 23;
		}

		this.gameObject.GetComponent<Image>().sprite = sprites [rand].GetComponent<SpriteRenderer>().sprite;
		current = sprites [rand];

		counter = 0;
		rate = 300;
		
	}

	void Update () {
		if (Time.timeScale != 0.0f) {
			counter++;
			if (counter % rate == 0) {

				rand = (int)Random.Range (0.0F, 24.0F);
				if (rand == 24) { 
					rand = 23;
				}
			
				this.gameObject.GetComponent<Image> ().sprite = sprites [rand].GetComponent<SpriteRenderer> ().sprite;
				current = sprites [rand];

				counter = 0;
				rate -= 1;
			}
		}
	}

	public static GameObject getSprite() {
		return current;
	}
}
