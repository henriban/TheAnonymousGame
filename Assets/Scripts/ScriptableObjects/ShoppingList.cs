using UnityEngine;

[CreateAssetMenu(fileName = "New ShoppingList", menuName = "ShoppingList")]
public class ShoppingList : ScriptableObject {

    public string owner;
    public string list;

    public int totalCost;

}
