using UnityEngine;
using System.Collections;

public class CannonManager : MonoBehaviour {
	
	private GameObject cannonOne;
	private GameObject cannonTwo;
	private GameObject cannonThree;
	private GameObject cannonFour;

	private int rand1, rand2, rand3, rand4;
	
	void Start () {

		cannonOne = transform.GetChild (0).gameObject;
		cannonTwo = transform.GetChild (1).gameObject;
		cannonThree = transform.GetChild (2).gameObject;
		cannonFour = transform.GetChild (3).gameObject;

	}

	void Update () {

		rand1 = (int)Mathf.Round (Random.Range(0,100));
		rand2 = (int)Mathf.Round (Random.Range(0,100));
		rand3 = (int)Mathf.Round (Random.Range(0,100));
		rand4 = (int)Mathf.Round (Random.Range(0,100));
		
		if (rand1 == 0 && !cannonOne.activeSelf)
			cannonOne.SetActive (true);
		//else
		//	cannonOne.SetActive (true);
		
		if (rand2 == 24 && !cannonTwo.activeSelf)
			cannonTwo.SetActive (true);
		//else
		//	cannonTwo.SetActive (true);
		
		if (rand3 == 49 && !cannonThree.activeSelf)
			cannonThree.SetActive (true);
		//else
		//	cannonThree.SetActive (true);
		
		if (rand4 == 99 && !cannonFour.activeSelf)
			cannonFour.SetActive (true);
		//else
		//	cannonFour.SetActive (true);
	}
	
}
