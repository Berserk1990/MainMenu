using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScenOnClick : MonoBehaviour {

	public void LoadByIndex(int index){
		SceneManager.LoadScene (index);
	}

	public void Quit(){
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
