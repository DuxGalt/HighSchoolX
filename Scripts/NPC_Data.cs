using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NPC_Data : MonoBehaviour {




	public List<Sprite> heads                   = new List<Sprite> ();
	public List<Sprite> faces                   = new List<Sprite> ();
	public List<Sprite> fatBodyTypeClothes      = new List<Sprite> ();
	public List<Sprite> skinnyBodyTypeClothes   = new List<Sprite> ();
	public List<Sprite> muscularBodyTypeClothes = new List<Sprite> ();
	public List<Sprite> normalBodyTypeClothes   = new List<Sprite> ();
	public List<Sprite> hair       = new List<Sprite> ();
	public List<Sprite> tempEffect = new List<Sprite> ();
	public List<Sprite> permEffect = new List<Sprite> ();

	public GameObject bodypart;
	public Game_Manager gm;

	public List<NPC> NPCs = new List<NPC> ();

	public int npcClassRatio;

	private string[] lastNames = {"Rexx", "Alexander", "Arthur", "Caesar", "Cedric", "Clause", "Cyrus", "Darius",
		"Demetrius", "Duke", "Edgar", "Egbert", "Evens", "Frederick", "Garret", "Godwin", "Grant", "Homer", "Ivan", "Jacobson",
		"James", "Joffrey", "Kenneth", "Konrad", "Lance", "Lars", "Lee", "Maxx",
		"Raymond", "Stefan", "Ash", "Victor", "Vaughn", "Vincent", "Linus", "Triston", "Phillips", "Williams", "Brightwall", "Jackson",
		"Gellet", "Alton", "Callard", "Newman", "Johnson", "Jocobson", "Black", "Goldman", "Copperfield", "Moog", "Gravett", "Foxx",
		"Draken", "Roger", "Steel", "Stannis", "Dodger", "Dickens", "Donner", "Winter", "Mithgar", "Garth", "Grand", "Hunter",
		"Hogsworth", "Keeper", "Wing", "Monty", "Powers", "Webstor", "Wood", "Norn", "Nickles", "Newton", "Zero", "London", "Grey",
		"Lancel", "Zet", "Jet", "Garmin", "Decker", "West", "Katt", "Cross", "Canton", "Gibson", "Arcus", "Knoxx", "Nikolai", "Raven",
		"Titan", "Forest", "Garder", "Archer", "Manson", "Maxwell", "Cole", "Stark", "Marx", "Hawkins", "Rivers", "Hawkston", "Smith",
		"Garfield", "Daniels", "Silver", "Hood", "Freedman", "Shiff", "Brown", "Redd", "Red", "Cline", "Crow"
	};

	private string[] firstNames = {"Jacob", "Michael", "Ethan", "Joshua", "Daniel", "Alexander", "Anthony", "William",
		"Christopher", "Matthew", "Jayden", "Andrew", "Joseph", "David", "Noah", "Aiden", "James", "Ryan", "Logan", "John",
		"Nathan", "Elijah", "Christian", "Gabriel", "Dominic", "Brady", "Kyle", "Antonio", "Miguel", "Eli", "Kaden", "Colton",
		"Benjamin", "Jonathan", "Tyler", "Samuel", "Nicholas", "Gavin", "Dylan", "Jackson", "Brandon", "Caleb", "Parker", "Mason",
		"Isaac", "Evan", "Jack", "Kevin,Jose", "Luke", "Landon", "Justin", "Lucas", "Zachary", "Jordan", "Robert", "Aaron", "Brayden",
		"Thomas", "Cameron", "Hunter", "Austin", "Adrian", "Connor", "Owen", "Aidan", "Jason", "Julian", "Wyatt", "Charles", "Luis",
		"Carter", "Chase", "Diego", "Jeremiah", "Brody", "Xavier", "Adam", "Carlos", "Sebastian", "Liam", "Hayden", "Nathaniel",
		"Henry", "Ian", "Tristan", "Bryan", "Sean", "Cole", "Alex", "Eric", "Brian", "Jaden", "Carson", "Ayden", "Cooper", "Levi", "Cody",
		"Max", "Oliver", "Oscar", "Alan", "Kenneth", "Paul", "Myles", "Axel", "Kyler", "Dawson", "", "Xander", "Jonas", "Colby",
		"Blake", "Steven", "Alejandro", "Riley", "Richard", "Timothy", "Devin", "Jesse", "Victor", "Jake", "Joel", "Colin", "Kaleb",
		"Vincent", "Ashton", "Preston", "Marcus", "Patrick", "Seth", "Jeremy", "Peyton", "Nolan", "Ivan", "Damian", "Maxwell",
		"Mark", "Giovanni", "Grant", "Collin", "Gage", "Omar", "Trevor", "Edward", "Cristian", "Nicolas", "Kayden", "George", "Jaxon",
		"Braden", "Elias", "Andres", "Derek", "Garrett", "Tanner", "Malachi", "Conner", "Fernando", "Cesar", "Miles", "Jaiden",
		"Alexis", "Leonardo", "Francisco", "Cayden", "Shane", "Edwin", "Hudson", "Travis", "Bryson", "Erick", "Jace", "Hector",
		"Peter", "Abraham", "Grayson", "Damien", "Kaiden", "Spencer", "Stephen", "Edgar", "Wesley", "Shawn", "Trenton", "Jared",
		"Jeffrey", "Landen", "Johnathan", "Bradley", "Braxton", "Ryder", "Camden", "Roman", "Asher", "Brendan", "Maddox", "Sergio",
		"Andy", "Lincoln", "Erik", "Donovan", "Raymond", "Avery", "Rylan", "Dalton", "Harrison", "Andre", "Martin", "Marco",
		"Dakota", "Leo", "Calvin", "Kai", "Drake", "Troy", "Zion", "Clayton", "Zane", "Gregory", "Tucker", "Rafael", "Kingston",
		"Dominick", "Ezekiel", "Griffin", "Devon", "Drew", "Lukas", "Johnny", "Ty", "Pedro", "Tyson", "Caiden", "Braylon",
		"Cash", "Aden", "Chance", "Taylor", "Marcos", "Maximus", "Ruben", "Simon", "Corbin", "Brennan", "Dillon", "Skyler",
		"Payton", "Brock", "Enrique", "Frank", "Quinn", "Malik", "Julio", "Derrick", "Fabian", "Corey", "Gerardo", "Dante",
		"Allen", "Theodore", "Amir", "Maximilian", "Randy", "Easton", "Dustin", "Luca", "Phillip", "Julius", "Charlie",
		"Ronald", "Jakob", "Cade", "Brett", "Trent", "Silas", "Keith", "Trey", "Darius", "Lane", "Jerry", "Jaime", "Scott",
		"Graham", "Weston", "Braydon", "Anderson", "Saul", "Danny", "Donald", "Elliot", "Dallas", "Lorenzo", "Casey", "Reid",
		"Mitchell", "Tristen", "Rowan", "Jayson", "Gustavo", "Aaden", "Amari", "Dean", "Declan", "Chris", "Dane", "Louis",
		"Arturo", "Brenden", "Felix", "Jimmy", "Cohen", "Tony", "Holden", "Bennett", "Zackary", "Arthur", "Nehemiah", "Ricky",
		"Esteban", "Dennis", "Finn", "Albert", "Marvin", "Mathew", "Larry", "Philip", "Quentin", "Curtis", "Greyson", "Alec",
		"Jameson", "Everett", "Darren", "Elliott", "Hugo", "Marshall", "Walter", "Jay", "Lance", "Ali", "Landyn", "Maurice",
		"Russell", "Leland", "Colten", "Reed", "Davis", "Joe", "Desmond", "Kade", "Reece", "Orlando", "Ryker", "Paxton",
		"Douglas", "Gary", "Lawrence", "Izaiah", "Solomon", "Tate", "Shaun", "Alvin", "Eddie", "Kane", "Titus", "Johan",
		"Jasper", "Chad", "Marc", "Kelvin", "Chandler", "Sam", "Reese", "Roger", "Talon", "Franklin", "Alijah", "Gunner",
		"Damon", "Emerson", "Micheal", "Bruce", "Terry", "Kolton", "Melvin", "Beckett", "Porter", "Dayton", "Leonel",
		"Keagan", "Carl", "Nelson", "Roy", "Walker", "Jack"
	};



	// Use this for initialization
	void Start () {

	
	
	}

	public void SpawnNPCs(int amount)
	{


		int fatTypeRatio = amount * 25 / 100;
		int musTypeRatio = amount * 25 / 100;
		int skiTypeRatio = amount * 25 / 100;
		int norTypeRatio = amount * 25 / 100;

		int fatTypeCounter = fatTypeRatio;
		int musTypeCounter = musTypeRatio;
		int skiTypeCounter = skiTypeRatio;
		int norTypeCounter = norTypeRatio;
					

		for(int i = 0; i < amount; ++i)
		{
			NPCs.Add(new NPC());
		}


		for(int i = 0; i < NPCs.Count; ++i)
		{	
			// give NPCs a ID
			NPCs[i].id = i;

			// Give NPCs a name
			NPCs[i].fName = firstNames[Random.Range(0, firstNames.Length)]; 
			NPCs[i].lName = lastNames[Random.Range(0, lastNames.Length)];
			NPCs[i].fullName = NPCs[i].fName + " " + NPCs[i].lName;



			//assign apperance



			if (fatTypeCounter > 0) 
			{
				NPCs[i].bodyType = "Fat";
				NPCs[i].clothes  = fatBodyTypeClothes [Random.Range (0, fatBodyTypeClothes.Count)];
				NPCs[i].hair     = hair[Random.Range(0,hair.Count)];
				NPCs[i].head     = heads [Random.Range (0, heads.Count)];
				NPCs[i].mouth    = faces[Random.Range(0,faces.Count)];
				fatTypeCounter--;
			}else if (norTypeCounter > 0) 
			{
				NPCs[i].bodyType = "Normal";
				NPCs[i].clothes  = normalBodyTypeClothes [Random.Range (0, normalBodyTypeClothes.Count)];
				NPCs[i].hair     = hair[Random.Range(0,hair.Count)];
				NPCs[i].head     = heads [Random.Range (0, heads.Count)];
				NPCs[i].mouth    = faces[Random.Range(0,faces.Count)];
				norTypeCounter--;
			}else if (skiTypeCounter > 0) 
			{
				NPCs[i].bodyType = "Skinny";
				NPCs[i].clothes  = skinnyBodyTypeClothes [Random.Range (0, skinnyBodyTypeClothes.Count)];
				NPCs[i].hair     = hair[Random.Range(0,hair.Count)];
				NPCs[i].head     = heads [Random.Range (0, heads.Count)];
				NPCs[i].mouth    = faces[Random.Range(0,faces.Count)];
				skiTypeCounter--;
			}else if (musTypeCounter > 0) 
			{
				NPCs[i].bodyType = "Muscular";
				NPCs[i].clothes  = muscularBodyTypeClothes [Random.Range (0, muscularBodyTypeClothes.Count)];
				NPCs[i].hair     = hair[Random.Range(0,hair.Count)];
				NPCs[i].head     = heads [Random.Range (0, heads.Count)];
				NPCs[i].mouth    = faces[Random.Range(0,faces.Count)];
				musTypeCounter--;
			}




		}//end npc loop
	

		//spawn npcs 
		Vector3 SpawnPos = Vector3.zero;
		for (int j = 0; j < NPCs.Count; j++) {
			
			GameObject spawned;
			spawned =	Instantiate (bodypart, SpawnPos, Quaternion.identity) as GameObject;
			spawned.name = j.ToString();
			NPCs [j].characterContainer = spawned;
			SpawnPos = SpawnPos + new Vector3(-5,0,0);

			GameObject body = Instantiate(bodypart,new Vector3(0,0,-10),Quaternion.identity) as GameObject;
			SpriteRenderer bodysprite = body.AddComponent<SpriteRenderer> ();
			bodysprite.sprite = NPCs [j].clothes;
			body.name ="Body";
		

			body.transform.SetParent (spawned.transform);
			body.transform.position = body.transform.parent.transform.position;

			GameObject head = Instantiate(bodypart,new Vector3(0,0,-9),Quaternion.identity) as GameObject;
			SpriteRenderer headsprite = head.AddComponent<SpriteRenderer> ();

			headsprite.sprite = NPCs [j].head;
			headsprite.sortingOrder = 1;

			head.transform.SetParent (spawned.transform);
			head.transform.position = head.transform.parent.transform.position;
			head.name = "Head";

			GameObject hair = Instantiate(bodypart,new Vector3(0,0,-9),Quaternion.identity) as GameObject;
			SpriteRenderer hairsprite = hair.AddComponent<SpriteRenderer> ();

			hairsprite.sprite = NPCs [j].hair;
			hairsprite.sortingOrder = 2;

			hair.transform.SetParent (spawned.transform);
			hair.transform.position = hair.transform.parent.transform.position;
			hair.name = "Hair";

			GameObject mouth = Instantiate(bodypart,new Vector3(0,0,-9),Quaternion.identity) as GameObject;
			SpriteRenderer mouthsprite = mouth.AddComponent<SpriteRenderer> ();

			mouthsprite.sprite = NPCs [j].mouth;
			mouthsprite.sortingOrder = 2;

			mouth.transform.SetParent (spawned.transform);
			mouth.transform.position = mouth.transform.parent.transform.position;
			mouth.name = "Mouth";

		}

	}//end spawn npcs






}