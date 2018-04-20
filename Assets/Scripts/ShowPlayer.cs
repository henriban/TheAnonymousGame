using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlayer : MonoBehaviour {

    public Button player1Button;
    public Button player2Button;

    private ColorBlock colorPlayer1Button;
    private ColorBlock colorPlayer2Button;

    private ReceiptDistributor receiptDistributor;

    void Start () {
        player1Button.onClick.AddListener(PlayerButton1Pressed);
        player2Button.onClick.AddListener(PlayerButton2Pressed);

        colorPlayer1Button = player1Button.GetComponent<Button>().colors;
        colorPlayer2Button = player2Button.GetComponent<Button>().colors;

        colorPlayer1Button.normalColor = Color.white;
        player1Button.GetComponent<Button>().colors = colorPlayer1Button;

        colorPlayer2Button.normalColor = Color.gray;
        player2Button.GetComponent<Button>().colors = colorPlayer2Button;


        receiptDistributor = GameObject.Find("ReceiptContent").GetComponent<ReceiptDistributor>();
    }

    private void PlayerButton1Pressed() {
        
        receiptDistributor.Player = 1;

        colorPlayer1Button.normalColor = Color.white;
        player1Button.GetComponent<Button>().colors = colorPlayer1Button;

        colorPlayer2Button.normalColor = Color.gray;
        player2Button.GetComponent<Button>().colors = colorPlayer2Button;

    }

    private void PlayerButton2Pressed() {
        receiptDistributor.Player = 2;
            
        colorPlayer1Button.normalColor = Color.gray;
        player1Button.GetComponent<Button>().colors = colorPlayer1Button;

        colorPlayer2Button.normalColor = Color.white;
        player2Button.GetComponent<Button>().colors = colorPlayer2Button;
    }
}
