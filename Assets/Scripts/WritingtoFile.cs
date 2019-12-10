using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class WritingtoFile : MonoBehaviour
{
    private string filename = @"scores.txt";
    private float some_variable;
    private string textToWrite = ScoreKeeper.newScore.ToString();

    void Update()
    {
        some_variable += Time.deltaTime;
        textToWrite = textToWrite + " " + some_variable.ToString();
        File.AppendAllText(filename, textToWrite);
    }
}