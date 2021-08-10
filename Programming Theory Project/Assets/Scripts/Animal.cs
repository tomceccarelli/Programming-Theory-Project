using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private string m_petName = "";
    public string petName
    {
        get
        {
            return m_petName;
        }
        protected set
        {
            if (value.Length > 10)
            {
                Debug.LogError("Your pet name is too long");
            }
            else
            {
                m_petName = value;
            }
        }
    }
    protected AudioSource voice { get; set; }
    protected bool isTalking { get; set; }

    public void Talk()
    {
        voice.Play();
    }

    public IEnumerator Talk(int times)
    {
        if (!isTalking)
        {
            isTalking = true;
            for (int i = 0; i < times; i++)
            {
                Talk();
                yield return new WaitForSeconds(1);
            }
            isTalking = false;
        }
    }

    protected string SetName(string name)
    {
        return name;
    }

    public abstract string DisplayInfo();

}
