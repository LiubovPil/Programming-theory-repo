using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    protected override void Talk()
    {
        Debug.Log($"{AnimalName} says Meow!");
    }
}
