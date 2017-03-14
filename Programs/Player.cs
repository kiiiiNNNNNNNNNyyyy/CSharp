using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player{

    int health;
    int power;
    string name;

    public Player(int h, int p, string n)
    {
        this.health = h;
        this.power = p;
        this.name = n;
    }

    public void info()
    {
        Debug.Log("Player created!! health = " + this.health + " power = " + this.power + " name = " + this.name);
    }

}
