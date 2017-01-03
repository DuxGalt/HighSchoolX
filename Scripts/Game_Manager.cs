using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game_Manager : MonoBehaviour {


	public int turnNum = 0;
	public int NPCSpawnAmount = 450;

	int classSize;
	int numClasses;
	int numGrades;
	int numClassesPerGrade;
	int numPeriods;

	int lastStudentAsigned;

	public string[] classSubjects = new string[5];

	public List<Classroom> Classrooms = new List<Classroom>();

	// data accesors
	public NPC_Data npcData;


	void Start () 
	{
		print (classSubjects.Length);
		classSize = 30;
		numClasses = NPCSpawnAmount / classSize;
		print (numClasses.ToString() );

		classSubjects[0] = "Math";
		classSubjects[1] = "Science";
		classSubjects[2] = "English";
		classSubjects[3] = "History";
		classSubjects[4] = "Gym";
		numPeriods = classSubjects.Length;
		print (numPeriods);
		numGrades = 3;
		numClassesPerGrade = numClasses / numGrades;
		print (numClassesPerGrade.ToString() );



		for (int i = 0; i < numGrades; i++) 
		{// for every grade (3)

			for (int j = 0; j < numClassesPerGrade; j++) 
			{// for every class in i Grade (5)x 3

				Classrooms.Add (new Classroom() );
				Classrooms [j].grade = i;



			}
					

		}//end for every grade 


		/// 
		/// classroom initalitaztion
		/// checklist
		/// 
		/// student age and grade X
		/// classroom grade x
		/// student asigned 6 classes
		/// class subject
		/// 


		npcData.SpawnNPCs (NPCSpawnAmount);
	
		//assign npcs a grade an age, then assign 5 classes for each npcs 1 for each subject,

	
	
	
	
	
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


//for(int k = 0; k < classSize; k++)
//{//add a new student to the class until class size met
//
//	// j represents the classroom, i is the grade, is the student within this class
//	// lastStudentAsigned + 1 is the current student ID/index  
//	npcData.NPCs [lastStudentAsigned++].grade = i;
//	npcData.NPCs [lastStudentAsigned++].age = 4 + i;// 4 being the age they entered school plus theier grade 
//
//}//end for every student
