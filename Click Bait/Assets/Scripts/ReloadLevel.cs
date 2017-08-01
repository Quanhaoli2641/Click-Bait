using UnityEngine;
using System.Collections;

public class ReloadLevel : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
	
	}

	public void reloadLevel(){
		Application.LoadLevel ("Game");
	}

	public void startScreen(){
		Application.LoadLevel ("Start Screen");
	}

}