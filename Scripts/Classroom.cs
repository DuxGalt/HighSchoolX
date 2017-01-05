using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[System.Serializable]
public class Classroom {

	public int grade;
	public int classID;

	//public GameObject node/location

	public string teacher;
	public string subject;
	//public string ClassName;

	//have a list of spaces in the room where students can stand/sit
	//this may need to turn into its own class so we can have data like if there is a desk
	// or interactable object on the spot, or if the spot is occupied/restricted
	public List<Vector3> classSpots = new List<Vector3>(); 

	// 5 lists of student ID's for each of this classrooms Classes
	public List<int> class1Students = new List<int>();
	public List<int> class2Students = new List<int>();
	public List<int> class3Students = new List<int>();
	public List<int> class4Students = new List<int>();
	public List<int> class5Students = new List<int>();
}
	