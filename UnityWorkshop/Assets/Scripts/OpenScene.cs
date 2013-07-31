using UnityEngine;
using System.Collections;

public class OpenScene : MonoBehaviour {

	public string nextLevel = "default";
	void Awake()
	{
		//1	
	}
	
	// Use this for initialization
	void Start () {
		//2
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//We asume it has a collider that will trigger this event
	void OnMouseDown()
	{
		Application.LoadLevel(nextLevel);	
	}
}
