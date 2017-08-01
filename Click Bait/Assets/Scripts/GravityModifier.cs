using UnityEngine;
using System.Collections;

public class GravityModifier : MonoBehaviour {

	private float randGrav;

	void Start () {

		randGrav = Random.Range (0.2f, LevelManager.getUpper());
		this.gameObject.GetComponent<Rigidbody2D> ().gravityScale = randGrav;

	}

	void Update () {

	}
}
