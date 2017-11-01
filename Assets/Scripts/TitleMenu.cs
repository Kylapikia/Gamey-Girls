using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TitleMenu : MonoBehaviour {

	public string firstLevel;
	public string selectLevel;

	public void NewGame() {
		SceneManager.LoadSceneAsync (firstLevel);
	}

	public void SelectLevel() {
		SceneManager.LoadSceneAsync (selectLevel);
	}

	public void QuitGame() {
		Application.Quit ();
	}
}
