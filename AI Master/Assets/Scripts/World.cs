using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class World : MonoBehaviour {

	public List<Tank>[]Tanks;
	public List<SpawnTower>[]SpawnTowers;
	public List<ExtractionTower>[]ExtractionTowers;
	TerrainCoordinatesAndContent WorldGrid = new TerrainCoordinatesAndContent();
	Player Players = new Player();
	List<GameObject> unitySpawnTowerObject;
	// Use this for initialization
	void Start () 
	{
		// Move the camerea to center of map


		// Start instantiating game objects
		Tanks = new List<Tank>[GameParameters.numberPlayers];
		SpawnTowers = new List<SpawnTower>[GameParameters.numberPlayers];
		ExtractionTowers = new List<ExtractionTower>[GameParameters.numberPlayers];

		
		for (int i=0; i < GameParameters.numberPlayers; i++) 
		{
			Tanks [i] = new List<Tank> ();
			SpawnTowers [i] = new List<SpawnTower> ();
			ExtractionTowers [i] = new List<ExtractionTower> ();
			
			// Spawn Towers
			int multi = i == 0 ? -1 : 1;
			SpawnTowers [i].Add (new SpawnTower (100, 100, new Vector2 (i * GameParameters.numberBlocksX - multi * GameParameters.startMapEdgeOffset, i * GameParameters.numberBlocksY - multi * GameParameters.startMapEdgeOffset)));
			SpawnTowers[i][0].Draw(ref WorldGrid);
		}


	}

	// Update is called once per frame
	void Update () 
	{
		Players.HaveTurn (ref SpawnTowers [0], ref Tanks[0]);


		//Draw calls (Render)
		for (int iplayer = 0; iplayer < GameParameters.numberPlayers; iplayer++)
		{
			for(int itank = 0; itank < Tanks[iplayer].Count; itank++)
		    {
				Tanks[iplayer][itank].Draw(ref WorldGrid);
			}

			for(int ispawnTower = 0; ispawnTower < SpawnTowers[iplayer].Count; ispawnTower++)
			{
				SpawnTowers[iplayer][ispawnTower].Draw(ref WorldGrid);
			}
		}
	}
}
