using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{

    private void Start()
    {
        petName = SetName(MainManager.Instance.dogName);
        voice = GetComponent<AudioSource>();
    }


    public override string DisplayInfo()
    {
        return "This is a dog.";
    }
}
