using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMonobehaviour : MonoBehaviour {

    public ExampleSO exampleSO;

    public void DoChangeListInScriptableObject(){
        for (int i = 0; i < 5; i++)
        {
            ExampleStruct newExampleStruct = new ExampleStruct("code-added value", (float)i);
            exampleSO.exampleStructs.Add(newExampleStruct);
        }
    }

}

[System.Serializable]
public class ExampleStruct
{
    public string exampleString;
    public float exampleFloat;

    public ExampleStruct(string newString, float newFloat)
    {
        exampleString = newString;
        exampleFloat = newFloat;
    }
}