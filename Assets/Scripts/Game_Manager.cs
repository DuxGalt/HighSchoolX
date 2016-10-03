using UnityEngine;
using System.Collections;

public class Game_Manager : MonoBehaviour {


	public int turnNum = 0;
	public int NPCSpawnAmount = 256;

	int classSize = 30;
	int numberClasses;
	// gym build restrictions 1-2 for hall1 and for hall2 3-4
	// Use this for initialization
	public NPC_Data npcData;

	void Start () 
	{
		numberClasses = NPCSpawnAmount / classSize;
		print (numberClasses.ToString ());

		npcData.SpawnNPCs (NPCSpawnAmount);
	}


	// Update is called once per frame
	void Update () 
	{
	
	}


	void EndTurn ()
	{
	

		turnNum ++;
	}
}
