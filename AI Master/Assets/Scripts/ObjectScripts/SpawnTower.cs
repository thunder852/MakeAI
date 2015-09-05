using UnityEngine;
using System.Collections;

public class SpawnTower : MonoBehaviour 
{
	//Defined attributes
	public int HitPoints;
	public int MassCapacityMaximum;
	public Vector2 Location;
	GameObject UnitySpawnTower = (GameObject)Instantiate (Resources.Load ("Buildings/SimpleBuilding"));
	
	//Instantaneous states
	public int MassCapacityCurrent;
	
	public SpawnTower(int aHitPoints, int aMassCapacityMaximum, Vector2 aLocation)
	{
		HitPoints = aHitPoints;
		MassCapacityMaximum = aMassCapacityMaximum;		
		Location = aLocation;

		MassCapacityCurrent = 0;
	}

	public Tank BuildTank()
	{
		return new Tank (1, 1, 1, 1, Location);
	}

	public void Draw(ref TerrainCoordinatesAndContent aworldGrid)
	{
		UnitySpawnTower.transform.position = aworldGrid.BlockToTerrainCoordinate (Location, 5);
	}
}
