using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReceiptDistributor : MonoBehaviour {

    public Transform contentPanel;
    public GameObject imagePrefab;
    public GameObject recieptOwnerTextPrefab;

    private List<GameObject> imageList = new List<GameObject>();
    private List<Sprite> images;
    private List<string> recieptOwnerNames = new List<string> { "Sam", "Taylor", "Jamie", "Cameron" };

    public int player = 1;

    void Start() {
        SetPlayerReceipts();

        GenerateReceiptImages();
        PopulateReceiptImages();
    }

    public void NextTurnReceipts() {
        SetPlayerReceipts();

        //RemoveOldReceipts();
        //GenerateReceiptImages();
        PopulateReceiptImages();
    }

    private void SetPlayerReceipts() {
        if (player == 1) {
            images = Data.ReciptsPlayer1;
        }
        else {
            images = Data.ReciptsPlayer2;
        }
    }

    private void RemoveOldReceipts() {
        foreach(GameObject image in imageList) {
            Destroy(image);
        }
        imageList = new List<GameObject>();
    }

    public void GenerateReceiptImages() {
        for (int i = 0; i < 4; i++) {
            GameObject text = Instantiate(recieptOwnerTextPrefab);
            text.GetComponent<Text>().text = recieptOwnerNames[i];

            text.transform.SetParent(contentPanel);
            text.transform.localScale = new Vector3(1, 1, 1);

            GameObject image = Instantiate(imagePrefab);
            image.transform.SetParent(contentPanel);
            image.transform.localScale = new Vector3(1, 1, 1);
            
            imageList.Add(image);
        }
    }

    public void PopulateReceiptImages() {
        for(int i = 0; i < images.Count; i++) {
            Image image = imageList[i].GetComponent<Image>();
            image.sprite = images[i];
            image.SetNativeSize();

            float width = image.rectTransform.rect.width / 2;
            float height = image.rectTransform.rect.height / 2;

            // Scaling large images
            if (width > 350) {
                float minus = width - 350;
                width = width - minus;
                height = height - (minus / 2);
            }

            image.rectTransform.sizeDelta = new Vector2(width, height);
        }
    }
}
