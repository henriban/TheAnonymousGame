using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayOfferPanel : MonoBehaviour {

    public GameObject offerPanel;
    public Button offerButton;
    public Button continueButton;

    private bool activeOfferPanel = false;

    void Start() {
        offerButton.onClick.AddListener(ClickOfferPanel);
        continueButton.onClick.AddListener(ClickOfferPanel);
    }

    public void ClickOfferPanel() {
        activeOfferPanel = !activeOfferPanel;
        offerPanel.SetActive(activeOfferPanel);
    }
}
