using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingListDistributor : MonoBehaviour {

    public List<ShoppingListItem> listToDisplay; // TODO: Do private and turnbased

    public Transform shoppingListPanel;
    public SimpleObjectPool shoppinglistObjectPool;

	void Start () {
        RefreshDisplay();
    }

    private void RefreshDisplay() {
        RemoveButtons();
        AddShoppingListItems();
    }

    private void RemoveButtons() {
        while (shoppingListPanel.childCount > 0) {
            GameObject toRemove = transform.GetChild(0).gameObject;
            shoppinglistObjectPool.ReturnObject(toRemove);
        }
    }

    private void AddShoppingListItems() {
        for (int i = 0; i < listToDisplay.Count; i++) {
            ShoppingListItem item = listToDisplay[i];
            GameObject newProductCard = shoppinglistObjectPool.GetObject();
            newProductCard.transform.SetParent(shoppingListPanel);

            ShopphingListDisplay listItem = newProductCard.GetComponent<ShopphingListDisplay>();
            listItem.Setup(item);
        }
    }
}
