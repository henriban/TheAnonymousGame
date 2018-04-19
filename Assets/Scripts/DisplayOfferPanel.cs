using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayOfferPanel : MonoBehaviour {
    
    public GameObject offerPanel;
    public Button offerButton;
    public Button continueButton;

    private bool activeOfferPanel = false;
    private bool readyToShowPanel = false;

    private ColorBlock offerButtonColor;

    private GameScript gameScript;
    private DropZoneManager dropZoneManager;
    private VarZoneDistributor varZoneDistributor;
    private ReceiptDistributor receiptDistributor;

    void Start() {
        continueButton.onClick.AddListener(Continue);

        offerButtonColor = offerButton.GetComponent<Button>().colors;

        offerButtonColor.normalColor = Color.gray;
        offerButton.GetComponent<Button>().colors = offerButtonColor;

        gameScript = GameObject.Find("GameManger").GetComponent<GameScript>();
        dropZoneManager = GameObject.Find("DropeZone").GetComponent<DropZoneManager>();
        varZoneDistributor = GameObject.Find("VarZone").GetComponent<VarZoneDistributor>();
        receiptDistributor = GameObject.Find("ReceiptContent").GetComponent<ReceiptDistributor>();
    }

    private void Continue() {
        gameScript.GetNextTurn();
        
        dropZoneManager.SpawnNewTurnOfSlots();        
        varZoneDistributor.NewTurn();
        varZoneDistributor.CheckOfferButton();
        receiptDistributor.NextTurnReceipts();

        ClickOfferPanel();
    }

    public void ClickOfferPanel() {
        activeOfferPanel = !activeOfferPanel;
        offerPanel.SetActive(activeOfferPanel);
    }

    public void SetOfferButtonClickable() {
        readyToShowPanel = true;
        UpdateOfferButton();
    }

    public void SetOfferButtonNotClickable() {
        readyToShowPanel = false;
        UpdateOfferButton();
    }

    private void UpdateOfferButton() {
        
        if (readyToShowPanel) {

            offerButtonColor.normalColor = Color.green;
            offerButtonColor.pressedColor = new Color(0, 0.6f, 0);
            offerButton.onClick.AddListener(ClickOfferPanel);
        }
        else {
            offerButtonColor.normalColor = Color.gray;
            offerButtonColor.pressedColor = Color.gray;
            offerButton.onClick.RemoveAllListeners();
        }

        offerButton.GetComponent<Button>().colors = offerButtonColor;
    }
}
