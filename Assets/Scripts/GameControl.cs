using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

	public GameObject gameOverText;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;

	public static GameControl instance;
	// Use this for initialization

	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}

	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (gameOver == true && Input.GetMouseButton(0)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

	public void BirdDied(){
		gameOverText.SetActive (true);
		gameOver = true;
	}
}
