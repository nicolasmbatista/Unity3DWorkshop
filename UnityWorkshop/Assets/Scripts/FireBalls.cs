using UnityEngine;
using System.Collections;

public class FireBalls : MonoBehaviour {
	
	public Transform bulletSpawner;
	public GameObject bullet;
	public float impulse = 1000;
	public float shootCadence = 3f;//1 bullet per 0.1 seconds
	
	private float nextShot = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1") && (nextShot < 0))
		{
			nextShot = shootCadence;
			GameObject newBullet = (GameObject)GameObject.Instantiate(bullet,bulletSpawner.position,bulletSpawner.transform.rotation);
			newBullet.rigidbody.AddRelativeForce(Vector3.forward*impulse);
		}else{
			nextShot -= Time.deltaTime * 1f;	
		}
	}
}
