using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[System.Serializable]
public class Classroom {

	public int grade;
	public int peirod;

	//public GameObject node/location
	public string teacher;
	public string subject;
	public string ClassName;

	public List<int> class1Students = new List<int>();
	public List<int> class2Students = new List<int>();
	public List<int> class3Students = new List<int>();
	public List<int> class4Students = new List<int>();
	public List<int> class5Students = new List<int>();
}
	