using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{

    private void Start()
    {
        petName = SetName(MainManager.Instance.catName);
        voice = GetComponent<AudioSource>();
    }


    public override string DisplayInfo()
    {
        return "This is a cat.";
    }
}
