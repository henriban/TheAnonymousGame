using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ShoppingList", menuName = "ShoppingList")]
public class ShoppingListItem : ScriptableObject {

    public string owner;
    public List<string> list;

    public int totalCost;

}
