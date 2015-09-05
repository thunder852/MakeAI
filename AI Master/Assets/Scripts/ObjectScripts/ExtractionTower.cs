using UnityEngine;
using System.Collections;

public class ExtractionTower : MonoBehaviour {

	//Defined attributes
	public int HitPoints;
	public int MassCapacityMaximum;
	public Vector2 Location;
	
	//Instantaneous states
	public int MassCapacityCurrent;
	
	public ExtractionTower(int aHitPoints, int aMassCapacityMaximum, Vector2 aLocation)
	{
		HitPoints = aHitPoints;
		MassCapacityMaximum = aMassCapacityMaximum;		
		Location = aLocation;
		
		MassCapacityCurrent = 0;
	}
}
