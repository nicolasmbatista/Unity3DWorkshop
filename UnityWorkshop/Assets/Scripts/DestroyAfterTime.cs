using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {
	
	public float lifetime = 4f;
	// Use this for initialization
	void Start () {
		Destroy(this.gameObject,lifetime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
