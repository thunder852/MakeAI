/*	This script requires a terrain object to be attached to it in the inspector
 * 	Contains: blockCoordinates
 * 			  blockContents
 * 			  GetBlockCoordinate
 */ 

using UnityEngine;
using System.Collections;

public class TerrainCoordinatesAndContent : MonoBehaviour {
	
	public Terrain terrain;

	//array containing the terrain coordinates of each block
	public static Vector2[][]blockCoordinates;//=new Vector2[GameParameters.numberBlocksX][];

	//array containing an integer identifier for item in a block. Zero (0) indicates an empty block
	public static int[][]blockContents;//=new int[GameParameters.numberBlocksX][];

	static float terrainSizeX;
	static float terrainSizeZ;

	void Start () 
	{
		//----------Set the coordinates for each block----------
		blockCoordinates=new Vector2[GameParameters.numberBlocksX][];
		blockContents=new int[GameParameters.numberBlocksX][];

		terrainSizeX = terrain.terrainData.size.x;
		terrainSizeZ = terrain.terrainData.size.z;

		for (int i=0; i<GameParameters.numberBlocksX; i++) 
		{
			blockCoordinates[i]=new Vector2[GameParameters.numberBlocksY];
			blockContents[i]=new int[GameParameters.numberBlocksY];
		}

		float blockLengthX = terrain.terrainData.size.x / GameParameters.numberBlocksX;
		float blockLengthY = terrain.terrainData.size.z / GameParameters.numberBlocksY;

		for (int i=0; i<GameParameters.numberBlocksX; i++) 
		{
			for (int j=0; j<GameParameters.numberBlocksY; j++) 
			{
				blockCoordinates[i][j]=new Vector2(i*blockLengthX,j*blockLengthY);
			}
		}
	}

	public Vector3 BlockToTerrainCoordinate(Vector2 aPosition, float aHeight)
	{
		return new Vector3 (aPosition.x/GameParameters.numberBlocksX*terrainSizeX, aHeight, aPosition.y/GameParameters.numberBlocksY*terrainSizeZ);
	}

}