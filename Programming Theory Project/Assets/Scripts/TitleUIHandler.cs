using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleUIHandler : MonoBehaviour
{
    [SerializeField]
    private InputField dogNameField;

    [SerializeField]
    private InputField catNameField;

    public void SubmitNames()
    {
        if (dogNameField.text.Length > 0 && catNameField.text.Length > 0)
        {
            MainManager.Instance.dogName = dogNameField.text;
            MainManager.Instance.catName = catNameField.text;

            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.LogError("You must input both names.");
        }
    }
}
