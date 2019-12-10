using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepData : MonoBehaviour
{
    public static string PlayerName = "Name";
    public static int Lives;
    public static int Speed;
    public static float Size;
    public static int Time;
    public static int Score;


    public InputField NameInput;
    public Dropdown LivesDropdown;
    public Dropdown SpeedDropdown;
    public Dropdown TimeDropdown;
    public Slider SizeSlider;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName()
    {
        PlayerName = NameInput.text;
    }

    public void SetLives()
    {
        Lives = LivesDropdown.value;
    }

    public void SetSpeed()
    {
        Speed = SpeedDropdown.value;
    }

    public void SetTime()
    {
        Time = TimeDropdown.value;
    }

    public void SetSize()
    {
        Size = SizeSlider.value;
    }

   
}
