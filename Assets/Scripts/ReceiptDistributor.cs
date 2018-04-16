using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReceiptDistributor : MonoBehaviour {

    public Transform contentPanel;
    public GameObject imagePrefab;

    private List<GameObject> imageList = new List<GameObject>();

    public List<Sprite> images;

    void Start() {
        GenerateReceiptImages();
        PopulateReceiptImages();
    }

    public void GenerateReceiptImages() {
        for (int i = 0; i < 4; i++) {
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

            image.rectTransform.sizeDelta = new Vector2(image.rectTransform.rect.width / 2, image.rectTransform.rect.height / 2);
        }
    }
}
