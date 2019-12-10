using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showData : MonoBehaviour
{
    public Text PlayerNameText;
    public Text SpeedDropdown;
    public Text TimeDropdown;
    public Text SizeSlider;
    public Text ScoreDisplay;

    private void Awake()
    {
        PlayerNameText.text = keepData.PlayerName;
        SpeedDropdown.text = keepData.Speed.ToString();
        TimeDropdown.text = keepData.Time.ToString();
        SizeSlider.text = keepData.Size.ToString();
        ScoreDisplay.text = ScoreKeeper.newScore.ToString();
    }

  
}
