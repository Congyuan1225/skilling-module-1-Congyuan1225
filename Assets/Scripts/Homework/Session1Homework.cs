using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour {

	public int myFirstWholeNumber = 1;
	public int mySecondWholeNumber = 3;
	public float myFirstDecimalNumber = 1.4545776f;
	public double myFirstLongDecimalNumber = 1.45457764545776d;
	private string myFirstWords = "Hello RC9! Happy to study this course!";
	public string mySecondWord = "Hello!";
	private bool myFristBoolean = false;
	public bool mySecondBoolean = true;
	public int[] myWholeNumbersCollection = new int[5];
	public float[] myDecimalNumbersCollection = { 1.1f, 2.2f, 3.3f };
	public List<int> myFirstIntList = new List<int>();
	private void MyFirstFunctionCalculatorSum(int _FirstNumber, int _SecondNumber)
	{
		int SumResult = _FirstNumber + _SecondNumber;
		return SumResult;

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
