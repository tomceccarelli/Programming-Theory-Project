using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField]
    private Toggle[] animalToggles = new Toggle[2];

    private Animal selectedAnimal;

    [SerializeField]
    private Text infoText;

    [SerializeField]
    private Button talkButton;

    public void ToggleAnimal(Toggle toggle)
    {
        if (toggle.isOn)
        {
            DisableActiveToggle(toggle);

            selectedAnimal = GetAnimalInfo(toggle);
            DisplayAnimalInfo();
        }
        else
        {
            selectedAnimal = null;
            talkButton.gameObject.SetActive(false);
            infoText.text = "Select a pet";
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

    private void DisplayAnimalInfo()
    {
        selectedAnimal.Talk();
        talkButton.gameObject.SetActive(true);
        infoText.text = selectedAnimal.DisplayInfo() + "\n It's name is " + selectedAnimal.petName;
    }

    public void StartTalking()
    {
        StartCoroutine(selectedAnimal.Talk(3));
    }
}
