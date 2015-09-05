using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class World : MonoBehaviour {

	public List<Tank>[]Tanks;
	public List<SpawnTower>[]SpawnTowers;
	public List<ExtractionTower>[]ExtractionTowers;
	TerrainCoordinatesAndContent WorldGrid = new TerrainCoordinatesAndContent();
	GameObject[] unitySpawnTowerObject = new GameObject[2];
	// Use this for initialization
	void Start () 
	{
		Tanks=new List<Tank>[GameParameters.numberPlayers];
		SpawnTowers=new List<SpawnTower>[GameParameters.numberPlayers];
		ExtractionTowers=new List<ExtractionTower>[GameParameters.numberPlayers];

		for (int i=0; i < GameParameters.numberPlayers; i++) 
		{
			Tanks [i] = new List<Tank> ();
			SpawnTowers [i] = new List<SpawnTower> ();
			ExtractionTowers [i] = new List<ExtractionTower> ();
			
			// Spawn Towers
			int multi = i == 0 ? -1 : 1;
			SpawnTowers [i].Add (new SpawnTower (100, 100, new Vector2 (i * GameParameters.numberBlocksX - multi * GameParameters.startMapEdgeOffset, i * GameParameters.numberBlocksY - multi * GameParameters.startMapEdgeOffset)));
			unitySpawnTowerObject [i] = (GameObject)Instantiate (Resources.Load ("Buildings/SimpleBuilding"));
			unitySpawnTowerObject [i].transform.position = WorldGrid.BlockToTerrainCoordinate (SpawnTowers [i] [0].Location, 5);
		}
	}

	// Update is called once per frame
	void Update () 
	{

	}
}
