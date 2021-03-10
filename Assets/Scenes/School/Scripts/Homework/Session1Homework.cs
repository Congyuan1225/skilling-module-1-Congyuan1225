using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/*
Session 1 homework:
Declare a int variable and set a value
Declare a float variable and set a value
Declare a string variable and set a value
Create a function that prints the declared variables
Declare and initialize an array
Declare and initialize a list
Create and initialize a Dictionary
 */
public class Session1Homework : MonoBehaviour {

	// 1.VARIABLES - data that is stored in your computer memory
	// Declaring Variables: Scope (visibility) -- Typer (numbers, words, logical) -- Name -- Value (optional)
	// Persistent - they will exist as long as the Gmae
	// HOMEWORK: Declare an int variable and set a value
	public int newIntNumber = 9;

	public int myFirstWholeNumber = 1;
	public int mySecondWholeNumber = 3;
	// HOMEWORK: Declare a float variable and set a value
	public float newFloatNumber = 9.999f;

	public float myFirstDecimalNumber = 1.4545776f;
	public double myFirstLongDecimalNumber = 1.45457764545776d;
	// HOMEWORK: Declare a string variable and set a value
	public string newStringWord = "Here is my Homework!";

	private string myFirstWords = "Hello RC9! Happy to study this course!";
	public string mySecondWord = "Hello!";
	// Logical (binary can be either true or false)
	private bool myFristBoolean = false;
	public bool mySecondBoolean = true;

	// 2.DATA STRUCTURE
	// Arrays
	// HOMEWORK: Declare and initialize an array 
	public int[] newIntArray = new int[9];

	public int[] myWholeNumbersCollection = new int[5];
	public float[] myDecimalNumbersCollection = { 1.1f, 2.2f, 3.3f };

	//Lists
	// HOMEWORK: Declare and initialize a list
	public List<int> newIntList = new List<int>();

	public List<int> myFirstIntList = new List<int>();
	
	// 3. FUNCTIONS
	//Declaring Functions: Scape -- Type -- Variables -- Body
	// HOMEWORK: Create a function that prints the declared variables 
	private int newFunction(int _FirstNumber, int _SecondNumber){
		int SumResult = _FirstNumber + _SecondNumber;
		return SumResult;
    }
	private float MyFirstFunctionCalculatorSum(float _FirstNumber, float _SecondNumber){
		float SumResult = _FirstNumber + _SecondNumber;
		return SumResult;
	}
	// Dictionary
	// HOMEWORK: Create and initialize a Dictionary
	Dictionary<string, string> animalFood =	new Dictionary<string, string>();
	

	// Start is called before the first frame update
	void Start () {
		// HOMEWORK: Create and initialize a Dictionary
		animalFood.Add("Cat", "Fish,Meat");
		animalFood.Add("Dog", "Bone,Meat");
		animalFood.Add("Mouse", "Cheese,Vegetable");
		animalFood.Add("Tiger", "Sheep,Meat");

		string food = animalFood["Dog"];
		Debug.Log(food);

		try
		{
			animalFood.Add("Cat", "Fish,Meat");
		}
		catch (ArgumentException)
		{
			Debug.Log("An element with Key = \"Cat\" already exists.");
		}

		foreach (KeyValuePair<string, string> kvp in animalFood)
		{
			Debug.Log( kvp.Key +","+ kvp.Value);
		}

		Dictionary<string, string>.ValueCollection valueColl = animalFood.Values;
		foreach (string s in valueColl)
		{
			Debug.Log("Value = {0}" + s);

		}


		// HOMEWORK: Create a function that prints the declared variables
		int SumResult2 = newFunction(newIntNumber, myFirstWholeNumber);
		Debug.Log(newStringWord + SumResult2.ToString() );

		//LOCAL - they will exist only temporary and be deleted after use
		float SumResult = MyFirstFunctionCalculatorSum(myFirstWholeNumber, mySecondWholeNumber);
		Debug.Log("Adding two numbers result is: " + SumResult.ToString());
		//Data in Arrays
		//Changing the data
		myDecimalNumbersCollection[0] = 2.8f;
		//Retriving the data
		float SumResult3 = MyFirstFunctionCalculatorSum(myDecimalNumbersCollection[0], myDecimalNumbersCollection[2]);
		//Data in Lists
		//Changing the data
		myFirstIntList.Add(3);
		myFirstIntList.Add(9);
		myFirstIntList[0] = 5;
		myFirstIntList[5] = 9;
		//Retriving the data
		Debug.Log(myFirstIntList[0]);

	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
}
