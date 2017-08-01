using UnityEngine;
using System.Collections;

public class ProjectileLauncher : MonoBehaviour {

	public Transform firePoint;
	public GameObject[] shapes;

	private float shotDelay;
	private float shotDelayCounter;

	private int num;
	private float lowerBound;

	private int counter;

	void Start () {
		lowerBound = 1f;
		shotDelayCounter = 1.0f;
		counter = 0;
	}

	void Update () {
		shotDelay = Random.Range(lowerBound, 2.0f);
		shotDelayCounter -= Time.deltaTime;
		if (shotDelayCounter <= 0) {
			shotDelayCounter = shotDelay;
			num = (int)Random.Range(0.0F,24.0F);
			if (num == 24) num = 23;
			Instantiate(shapes[num], firePoint.position, firePoint.rotation);
		}
		counter++;
		if (counter % 600 == 0) {
			if (lowerBound >= 0.25)
				lowerBound -= 0.01f;
			counter = 0;
		}
	}
}