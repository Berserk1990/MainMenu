using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour {

	[SerializeField]
	private GameObject _selectObject;

	private bool _buttonObject;


	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetAxis ("Vertical") != 0 && !_buttonObject) {
			EventSystem.current.SetSelectedGameObject (_selectObject);
			_buttonObject = true;
		}
	}

	private void OnDisable(){
		_buttonObject = false;
	}
}
