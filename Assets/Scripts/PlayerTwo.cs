using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTwo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI outputText;

    string Name = "Batman";
    int Age = 50;
    float Health = 99999.99f;
    int AuraLevel = 99999;
    int DucksHeld = 2;

    public void Rewrite()
    {
        outputText.text = "Name: " + Name + "\n\rAge: " + Age + "\n\rHealth: " + Health + "\r\nAura Level: " + AuraLevel + "\r\nDucks Held: " + DucksHeld;
    }
}
