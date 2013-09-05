using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	
	public float BulletSpeed = 5;
	
	Vector3 Velocity;
	
	public void initBullet(string Direction, Transform InitialPosition)
	{
		if(Direction.Equals ("north",System.StringComparison.InvariantCultureIgnoreCase))
		{
			Velocity = new Vector3(0, 0, 1);
		}
		else if (Direction.Equals ("south",System.StringComparison.InvariantCultureIgnoreCase))
		{
			Velocity = new Vector3(0, 0, -1);
		}
		else if (Direction.Equals ("east",System.StringComparison.InvariantCultureIgnoreCase))
		{
			Velocity = new Vector3(1, 0, 0);
		}
		else if (Direction.Equals ("west",System.StringComparison.InvariantCultureIgnoreCase))
		{
			Velocity = new Vector3(-1, 0, 0);
		}
		transform.position += Velocity * 2;
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Velocity * Time.deltaTime * BulletSpeed;
	}
	
	void OnCollisionEnter(Collision collision) {
        Object.Destroy(this.gameObject);
	}
}
