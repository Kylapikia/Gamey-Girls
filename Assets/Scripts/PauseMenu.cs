using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public bool isPaused;
	public GameObject pauseCanvas;
	public string mainMenu;
	public string selectLevelScene;

	void Update () {
		if (isPaused) {
			pauseCanvas.SetActive (true);
			Time.timeScale = 0f;
		} else {
			pauseCanvas.SetActive (false);
			Time.timeScale = 1f;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			isPaused = !isPaused;
		}
	}

	public void QuitToMenu() {
		SceneManager.LoadSceneAsync (mainMenu);
	}

	public void SelectLevel() {
		SceneManager.LoadSceneAsync (selectLevelScene);
	}

	public void QuitGame() {
		Application.Quit ();
	}
}
