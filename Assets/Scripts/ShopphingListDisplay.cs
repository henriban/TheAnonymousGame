using UnityEngine;
using UnityEngine.UI;

public class ShopphingListDisplay : MonoBehaviour {

    public Text ownerText;
    public Text listText;
    public Text totalCostText;

    public void Setup(ShoppingListItem shoppingList) {

        ownerText.text = shoppingList.owner;
        listText.text = shoppingList.list;
        totalCostText.text = shoppingList.totalCost.ToString() + "kr";

    }
}
