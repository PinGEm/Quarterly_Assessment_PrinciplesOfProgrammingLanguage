using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerThree : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI outputText;

    string Name = "Marcus Ureta";
    int Age = 1;
    float Health = 2.95f;
    int AuraLevel = 1;
    int DucksHeld = 9999;

    public void Rewrite()
    {
        outputText.text = "Name: " + Name + "\n\rAge: " + Age + "\n\rHealth: " + Health + "\r\nAura Level: " + AuraLevel + "\r\nDucks Held: " + DucksHeld;
    }
}
