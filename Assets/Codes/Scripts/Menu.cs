using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    // [Header("References")]
    public TextMeshProUGUI moneyUI;
    public TextMeshProUGUI roundUI;
    public TextMeshProUGUI livesUI;



    private void Update() {
        livesUI.text = PlayerStats.Lives + " LIVES";
        roundUI.text =  "Wave:" + PlayerStats.rounds.ToString();
        moneyUI.text = "₱" + PlayerStats.Money.ToString();

    }
    
}
