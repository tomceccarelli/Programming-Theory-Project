using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{

    private void Start()
    {
        petName = "Médor";
        voice = GetComponent<AudioSource>();
    }


    public override string DisplayInfo()
    {
        return "This is a dog.";
    }
}
