using UnityEngine;
using UnityEngine.UI;

public class ShopphingListDisplay : MonoBehaviour {

    public Text ownerText;
    public Transform listText;
    public Text totalCostText;

    public GameObject textObject;

    public void Setup(ShoppingListItem shoppingList) {

        ownerText.text = shoppingList.owner;

        foreach(string item in shoppingList.list) {
           
            GameObject newText = (GameObject)Instantiate(textObject);
           
            Text theText = newText.transform.GetComponent<Text>();
            
            theText.text = item;

            newText.transform.SetParent(listText);
        }

        totalCostText.text = shoppingList.totalCost.ToString() + "kr";

        transform.localScale = new Vector3(1, 1, 1); // Forc to dont scale
    }
}
