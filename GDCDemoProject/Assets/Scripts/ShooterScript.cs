using UnityEngine;
using System.Collections;

public class ShooterScript : MonoBehaviour {
	public Transform Bullet = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 FireDirection = new Vector2(Input.GetAxis("FireHorizontal"), Input.GetAxis("FireVertical"));
		
		// We use square magnitude because it is more efficient than square rooting plus we are only checking for non-zero here
		if(FireDirection.sqrMagnitude > 0)
		{
			GameObject newBullet = Instantiate(Bullet, transform.position, Quaternion.identity) as GameObject;
			newBullet.GetComponent<BulletScript>().initBullet("",transform);
		}
	}
}
