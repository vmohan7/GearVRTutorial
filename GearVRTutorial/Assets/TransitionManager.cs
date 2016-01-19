using UnityEngine;
using System.Collections;

public class TransitionManager : MonoBehaviour {

	public static TransitionManager Instance;

	private int currentScene = 0;

	void Awake() {
		if (Instance == null)
			Instance = this;
	}

	void OnDestroy() {
		if (Instance == this)
			Instance = null;
	}

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			LoadNextScene ();
		}
	}

	private void LoadNextScene() {
		currentScene = (currentScene + 1) % Application.levelCount;
		Application.LoadLevel (currentScene);
	}
}
