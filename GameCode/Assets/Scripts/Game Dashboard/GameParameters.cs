using UnityEngine;

public class GameParameters : MonoBehaviour
{
	//Variables for Unity Inspector
	public int numberOfPlayers=2;
	public int numberOfBlocksX=100;
	public int numberOfBlocksY=100;
	public int startOfMapEdgeOffset=10;

	//Static Variables to be used by scripts
	public static int numberPlayers;
	public static int numberBlocksX;
	public static int numberBlocksY;
	public static int startMapEdgeOffset;

	//Set static variables
	void Awake ()
	{
		numberPlayers = numberOfPlayers;
		numberBlocksX = numberOfBlocksX;
		numberBlocksY = numberOfBlocksY;
		startMapEdgeOffset = startOfMapEdgeOffset;
	}

}
