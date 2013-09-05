using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {
	public int NumberOfEnemies = 50;
	public Transform EnemyPrefab = null;
	// Use this for initialization
	void Start () {
		Spawn();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Spawn(){
		for(int i = 0; i < NumberOfEnemies; i++)
		{
			Transform newEnemy = (Transform)Instantiate(EnemyPrefab, new Vector3(Random.Range(-45, 45), 4, Random.Range(-45, 45)), Quaternion.identity);  
			newEnemy.gameObject.GetComponent<EnemyCollisionInteractions>().gameControler = this.gameObject;
		}
	}
}
