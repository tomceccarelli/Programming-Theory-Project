using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cat : Animal
{

    private void Start()
    {
        petName = SetName(MainManager.Instance.catName);
        voice = GetComponent<AudioSource>();
    }

    // POLYMORPHISM
    public override string DisplayInfo()
    {
        return "This is a cat.";
    }
}
