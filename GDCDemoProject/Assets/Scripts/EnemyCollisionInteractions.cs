using UnityEngine;
using System.Collections;

public class EnemyCollisionInteractions : MonoBehaviour {
	[System.NonSerialized]
	public GameObject gameControler = null; 
	public int EnemyWorthPoints = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < 0){
			transform.position = new Vector3 (transform.position.x, 5, transform.position.z);
		}
	}
	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name.Equals("BulletPrefab(Clone)"))
		{
			gameControler.GetComponent<GameControler>().AddScore(EnemyWorthPoints);
			Object.Destroy(this.gameObject);
		}
	}
}
