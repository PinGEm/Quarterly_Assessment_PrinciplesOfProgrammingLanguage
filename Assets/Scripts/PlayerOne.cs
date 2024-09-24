using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerOne : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI outputText;

    string Name = "Joe Trump";
    int Age = 150;
    float Health = 0.5f;
    int AuraLevel = 5;
    int DucksHeld = 5;

    public void Rewrite()
    {
        outputText.text = "Name: " + Name + "\n\rAge: " + Age + "\n\rHealth: " + Health + "\r\nAura Level: " + AuraLevel + "\r\nDucks Held: " + DucksHeld;
    }
}
