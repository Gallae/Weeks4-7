using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptingProblems : MonoBehaviour
{
	public TMPro.TMP_Text premiseText;
	public TMPro.TMP_Text resultText;

	private void Start()
	{
		//SwapNumbers();
		//FindHighestNumber();
		IncreaseAge();
		//MovePosition();
	}

	public void SwapNumbers()
	{
		premiseText.text = "Swapping numbers: 5 and 3";
		int firstNumber = 5;
		int secondNumber = 3;

		//firstNumber = secondNumber;
		//Debug.Log("firstNumber: " + firstNumber + ", secondNumber: " + secondNumber);
		//secondNumber = firstNumber;
		//Debug.Log("firstNumber: " + firstNumber + ", secondNumber: " + secondNumber);
		int placeholder = firstNumber;
		firstNumber = secondNumber;
		secondNumber = placeholder;
        resultText.text = "First number["+firstNumber.ToString()+"], Second number["+secondNumber.ToString()+"]";
		//issue arises from setting firstNumber to be equal to
		//secondNumber without having a placeholder variable to
		//store the original value of firstNumber
	}

	public void FindHighestNumber()
	{
		premiseText.text = "Finding the highest number out of 4, 3, 5, 1, 12, 6, 2";
		List<int> numbers = new List<int>() { 4, 3, 5, 1, 12, 6, 2 };
		int highestNumber = 0;
		for (int i = 0; i < numbers.Count; i++)
		{
			if (numbers[i] > highestNumber)
			{
				//highestNumber = i;
				highestNumber = numbers[i];
                Debug.Log("highestNumber is currently" + highestNumber);
            }
		}
		resultText.text = "Highest number["+highestNumber.ToString()+"]";
		//issue arises from setting highestNumber to i, which is just the index
		//of the for loop. once i = 6, the if statement is no longer true and stops
		//setting highestNumber to i. changing line 43 to "highestNumber = numbers[i]"
		//fixes the problem.
	}

	class Person
	{
		public int age = 0;
		public string name = "";

		public Person()
		{
		}

		public Person(int inAge, string inName)
		{
			age = inAge;
			name = inName;
		}
	}

	public void IncreaseAge()
	{
		Person alice = new Person(32, "Alice");
		Person thomas = new Person(24, "Thomas");

		int ageIncrease = 3;
		premiseText.text = "Increasing age of Alice and Thomas";

		Debug.Log("alice.age is " + alice.age + ", thomas.age is " + thomas.age);

		alice.age += ageIncrease;
        Debug.Log("alice.age is " + alice.age + ", thomas.age is " + thomas.age);
        thomas.age += ageIncrease;
        Debug.Log("alice.age is " + alice.age + ", thomas.age is " + thomas.age);
        resultText.text = "Alice is now "+alice.age.ToString()+" years old and Thomas is now "+thomas.age.ToString()+" years old.";
		//issue arises from misnaming the age component on the Person constructor. The name of the variable Person()
		//takes in is inAge, while this code is adding 3 to .age, a property which was previously undefined, causing
		//it to be 0. changing this text to "alice.inAge" and "thomas.inAge" would fix the problem.
	}

	public void MovePosition()
	{
		Vector3 currentPosition = new Vector3(1.5f, 2.5f, 3.5f);
		premiseText.text = "Moving the position " + currentPosition.ToString();
		float shiftedX = 3f + (float)currentPosition.x;
		Debug.Log((float)currentPosition.x);
		currentPosition.x = shiftedX;
		resultText.text = "Position is now " + currentPosition.ToString();
		//issue arises from declaring shiftedX as an int and adding it to a
		//currentPosition.x which has been cast to an int. changing both
		//variables to floats would solve the issue.
	}

}
