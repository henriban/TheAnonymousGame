using UnityEngine;
using UnityEngine.UI;

public class ShopphingListDisplay : MonoBehaviour {

    public ShoppingList shoppingList;

    public Text ownerText;
    public Text listText;
    public Text totalCostText;

    void Start() {

        ownerText.text = shoppingList.owner;
        listText.text = shoppingList.list;
        totalCostText.text = shoppingList.totalCost.ToString() + "kr";

    }
}
