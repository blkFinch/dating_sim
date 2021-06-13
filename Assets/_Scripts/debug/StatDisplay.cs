using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatDisplay : MonoBehaviour
{
    Text text;
    string displayText;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        DisplayText();
    }

    public void DisplayText()
    {
        displayText = "STR: " + Player.active.GetStat(PlayerStatType.STR) + "\n";
        displayText += "INT: " + Player.active.GetStat(PlayerStatType.INT) + "\n";
        displayText += "CHA: " + Player.active.GetStat(PlayerStatType.CHA) + "\n";
        displayText += "SOC: " + Player.active.GetStat(PlayerStatType.SOC) + "\n";
        displayText += "NAME: " + Player.active.GetName();

        text.text = displayText;
    }

    private void Update() {
        DisplayText();
    }

}
