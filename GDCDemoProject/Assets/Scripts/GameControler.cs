using UnityEngine;
using System.Collections;

public class GameControler : MonoBehaviour {
	
	int score = 0;
	bool gameOver = false;
	SpawnEnemies spawner;
	int numEnemies;
	int killedEnemies = 0;
	// Use this for initialization
	void Start () {
		spawner = GetComponent<SpawnEnemies>();
		numEnemies = spawner.NumberOfEnemies;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
		if(!gameOver)
		{
			GUI.Box(new Rect(10, 10, 200, 50), string.Format("Score: {0}", score));
		}
		else
		{
			GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 500), "Game Over");
		}
	}
	
	public void AddScore(int scoreAdd){
		score += scoreAdd;
		killedEnemies++;
		if(killedEnemies == numEnemies)
		{
			LevelCleared();
		}
	}
	
	public void LevelCleared(){
		spawner.Spawn();
	}
	
	public void GameOver(){
		gameOver = true;
	}
}
