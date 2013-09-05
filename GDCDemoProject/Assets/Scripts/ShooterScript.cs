using UnityEngine;
using System.Collections;

public class ShooterScript : MonoBehaviour {
	public Transform Bullet = null;
	public float bulletSecs = .15f;
	public GameObject GameControler = null;
	float timeSinceLastFired = 200;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 FireDirection = new Vector2(Input.GetAxis("FireHorizontal"), Input.GetAxis("FireVertical"));
		timeSinceLastFired += Time.deltaTime;
		// We use square magnitude because it is more efficient than square rooting plus we are only checking for non-zero here
		if(FireDirection.sqrMagnitude > 0)
		{
			if(timeSinceLastFired > bulletSecs)
			{	timeSinceLastFired = 0;
				Transform newBullet = (Transform)(Instantiate(Bullet, transform.position, Quaternion.identity));
				if(Input.GetAxis("FireHorizontal") > 0)
				{
					newBullet.GetComponent<BulletScript>().initBullet("east",transform);
				}
				else if (Input.GetAxis("FireHorizontal") < 0)
				{
					newBullet.GetComponent<BulletScript>().initBullet("west",transform);
				}
				else if (Input.GetAxis("FireVertical") > 0)
				{
					newBullet.GetComponent<BulletScript>().initBullet("north",transform);
				}
				else if (Input.GetAxis("FireVertical") < 0)
				{
					newBullet.GetComponent<BulletScript>().initBullet("south",transform);
				}
			}
		}
	}
	
	void OnTriggerEnter(Collider hit)
	{
		if(hit.gameObject.name.Equals("EnemyPrefab(Clone)"))
		{
			GameControler.GetComponent<GameControler>().GameOver();
			Object.Destroy(this.gameObject);
		}
	}
}
