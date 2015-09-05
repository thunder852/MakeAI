using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

	public void HaveTurn(ref List<SpawnTower> aSpawnTowers, ref List<Tank> Tanks)
	{
		if (Tanks.Count < 10) 
		{
			Tanks.Add (aSpawnTowers [0].BuildTank ());

			for (int itank = 0; itank < Tanks.Count; itank++) 
			{
				Vector2 tankLocation = Tanks [itank].Location;
				tankLocation.x += 1;
				tankLocation.y += 1;
				Tanks [itank].Move (tankLocation);
			}
		}
	}
}
