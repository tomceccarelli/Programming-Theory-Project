using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField]
    private Toggle[] animalToggles = new Toggle[2];

    [SerializeField]
    private Text infoText;

    public void ToggleAnimal(Toggle toggle)
    {
        Animal pet = GetAnimalInfo(toggle);

        if (toggle.isOn)
        {
            DisableActiveToggle(toggle);
            DisplayAnimalInfo(pet);
        }
        else
        {
            infoText.text = "";
        }
    }

    private Animal GetAnimalInfo(Toggle toggle)
    {
        if (toggle.CompareTag("Cat"))
        {
            Cat animal = toggle.GetComponent<Cat>();
            return animal;
        }
        else if (toggle.CompareTag("Dog"))
        {
            Dog animal = toggle.GetComponent<Dog>();
            return animal;
        }
        return null;
    }

    private void DisableActiveToggle(Toggle toggle)
    {
        foreach (var animalToggle in animalToggles)
        {
            if (animalToggle != toggle)
            {
                animalToggle.isOn = false;
            }
        }
    }

    private void DisplayAnimalInfo(Animal animal)
    {
        StartCoroutine(animal.Talk(3));
        infoText.text = animal.DisplayInfo() + "\n It's name is " + animal.petName;
    }
}
