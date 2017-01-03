using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class NPC{

	public string    fName;
	public string    lName;
	public string fullName;
	public string     gang;
	public string nickname;
	public int       id;
	public int    level;
	public int      age;
	public int    grade;
	public float  money;
	public float health;
	public float     xp;

	//appereence
	public GameObject characterContainer;

	public string    bodyType;
	public string    headType;
	public string  tempEffect;
	public string    hairType;

	public Sprite        head;
	public Sprite       mouth;
	public Sprite     clothes;
	public Sprite tempFeature;
	public Sprite permFeature;
	public Sprite        hair;



	public bool isMale;
	public bool isGangMember;


	public List<int> Classes = new List<int>(6);

	public int dexterity;
	public int intimidation;
	public int charisma;
	public int strengh;
	public int stealth;
	public int intelligence;
	public int stamina;

	public int math;
	public int science;
	public int physicalEducation;
	public int english;
	public int history;
	//items/inventory




}
