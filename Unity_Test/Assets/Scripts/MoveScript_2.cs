using UnityEngine;
using System.Collections;

public class MoveScript_2 : MonoBehaviour {

	public Transform WayPoint=null;
	public float speed = 4.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		this.transform.Translate (WayPoint.position);
	}
}
