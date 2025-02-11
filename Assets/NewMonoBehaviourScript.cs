using UnityEngine;
using TMPro;
using System;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public TMP_Text text;  // Ensure this is public to assign in the Inspector

    void Start()
    {
       
    }
    void Update()
    {
        
    }
    public void button()
    {
        if (text != null)
        {
            text.text = "Hello World";
        }
        else
        {
            Debug.LogError("Text is not assigned!");
        }
    }
}
