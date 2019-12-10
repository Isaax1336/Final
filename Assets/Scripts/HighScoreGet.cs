using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class HighScoreGet : MonoBehaviour
{
    private static string filepath = @"scores.txt";
    public Text Scores;

    public void Start()
    {
    string[] scoreList = File.ReadAllLines(filepath);
        Scores.text = "";

        for(int i = 0; i < scoreList.Length; i++)
        {
            Scores.text = Scores.text + scoreList[i] + "\n";
        }

    }
    

}
