using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game_Manager : MonoBehaviour {


	public int turnNum;
	public int NPCSpawnAmount;

	int sClassSize;
	int mClassSize;
	int lClassSize;
	int selectedSize;

	int numClasses;
	int numClassrooms;
	int numGrades;
	int numClassesPerGrade;
	int numPeriods;
	int numClassPerSubjectsPerGrade;
	int lastStudentAsigned;
	int studentsPerClass;

	public string[] classSubjects;

	public List<Classroom> Classrooms = new List<Classroom>();

	// data accesors
	public NPC_Data npcData;


	void Start () 
	{ 


		/// 
		/// classroom initalitaztion
		/// checklist
		/// 
		/// student age and grade X
		/// classroom grade x
		/// student asigned 6 classes
		/// class subject
		/// 
		//	so if i take the total number of students, divide that into the 3 grades, 
		//	then take that number and divide it by the min class size,
		//  then multiply that number by the subjects giving us the total number of classes needed to be filled
		//  then divide that by the number of periods so that we have the amount of classes at any one time so total classrooms.


		classSubjects  = new string[] { "Math", "Science", "English", "History", "Gym"};
		numGrades      =  3;
		numPeriods     =  5;
		sClassSize = 10;
		mClassSize = 20;
		lClassSize = 30;

		//TODO Make this a UI button and remove this
		selectedSize       = mClassSize;
		studentsPerClass   = selectedSize;
		numPeriods         = classSubjects.Length;
		numClasses         = NPCSpawnAmount / selectedSize * classSubjects.Length;//total number of classes needed 
		numClassesPerGrade = numClasses / numPeriods /numGrades;// classes per grade
		numClassrooms      = numClasses / classSubjects.Length;

		numClassPerSubjectsPerGrade = numClassesPerGrade / classSubjects.Length;



		print ("Total Students "+ NPCSpawnAmount);
		print ("Total number of Classes " + numClasses.ToString() );
		print ("Number of time Peierds "+numPeriods);
		print ("Number of classes per grade "+numClassesPerGrade.ToString() );
		print ("Classrooms needed " + numClassrooms);
		print ("Number of Classrooms per subject in each grade " + numClassPerSubjectsPerGrade);

		int currentGrade = 1;// current grade, used to ofset the 0th of the class index
		int index = 0;//the current classroom

		//check that there is the minimum reqired classrooms per grade


		for(int i = 0; i < numGrades;i++)
		{// do for every grade
			
			for(int j = 0; j < numClassesPerGrade;j++)
			{// do for every class in this grade
				Classrooms.Add (new Classroom () );//add the classroom
				Classrooms [index].grade   = currentGrade;// set the grade 
				Classrooms [index].classID = index;// set ID for future calls and reference(may not be used)
				// add some code to asign a class subject with numClassPerSubjectsPerGrade

				index++;

				for(int n = 0; n < numPeriods;n++)
				{//for every class in this index classroom class is n and can only run 5 times!
					//this loop will be used to assign students to each class in this classroom
				}


			}
			currentGrade++;//when we are done assigning all classes for this grade change the grade
		}


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
