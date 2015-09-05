using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour 
{
	//Defined attributes
	public int HitPoints;
	public int MassCapacityMaximum;
	public int AttackDamage;
	public int Speed;

	//Instantaneous states
	public Vector2 Location;
	public int MassCapacityCurrent;

	public Tank(int aHitPoints, int aMassCapacityMaximum, int aAttackDamage, int aSpeed, Vector2 aLocation)
	{
		HitPoints = aHitPoints;
		MassCapacityMaximum = aMassCapacityMaximum;
		AttackDamage = aAttackDamage;
		Speed = aSpeed;

		Location = aLocation;
		MassCapacityCurrent = 0;
	}
}
