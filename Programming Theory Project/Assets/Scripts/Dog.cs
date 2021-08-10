using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : Animal
{

    private void Start()
    {
        petName = SetName(MainManager.Instance.dogName);
        voice = GetComponent<AudioSource>();
    }

    // POLYMORPHISM
    public override string DisplayInfo()
    {
        return "This is a dog.";
    }
}
