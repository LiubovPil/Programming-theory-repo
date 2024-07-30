using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    protected override void Talk()
    {
        Debug.Log($"{AnimalName} says woof");
    }
}
