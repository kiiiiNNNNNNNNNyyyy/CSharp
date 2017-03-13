using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNewScript : MonoBehaviour {

    float speed = 2.3f; //we eed to add f at the end to show that it is a float variable coz it creates conflicts with double
    double power = 4.2; // We don't add f or d at the end. Double is more precise that float
    int health = 23;    // a whole number
    string name = "Warrior";    //sequence of character
    bool isOn = false;

    void Awake()
    {
        printSomething();    
    }

	// Use this for initialization
	void Start () {                 // called right away, when we the app starts
        printSomething();
        Debug.Log("Printed from Log");
        print("Here is a String!!");
        printArgument("This is a function that takes an argument");
        int a = returnValue();
        print(a);

        if (a > 0)
        {
            print("a is greater than 0");
        }

        int maxSpeed = 5;
        int speed2 = 3; 
        switch (speed2)
        {
            case 1:
                Debug.Log("speed is " + 1);
                break;

            case 2:
                Debug.Log("speed is " + 2);
                break;

            case 3:
                Debug.Log("speed is " + 3);
                break;

            case 4:
                Debug.Log("speed is " + 4);
                break;

            default:
                print("Nothing get executed");
                break;
        }

        for(int i=0; i<10; i++)
        {
            print("For LOOP " + i);
        }

        while (a < 10)
        {
            Debug.Log("while LOOP " + a);
            a++;
        }

        array();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void printSomething()
    {
        Debug.Log("Printed from function");
    }

    void printArgument(string message)
    {
        Debug.Log(message);
    }

    int returnValue()
    {
        return 2;
    }

    void array()
    {
        int[] a = new int[10];

        for(int i=0; i<10; i++)
        {
            a[i] = Random.Range(1, 100);
        }

        for(int i=0; i<a.Length; i++)
        {
            print(a[i]);
        }
    }
}