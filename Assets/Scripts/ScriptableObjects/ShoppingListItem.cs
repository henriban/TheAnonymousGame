using System;
using UnityEngine;

[CreateAssetMenu(fileName = "New ShoppingList", menuName = "ShoppingList")]
public class ShoppingListItem : ScriptableObject {

    public string owner;
    public string list;

    public int totalCost;

}
