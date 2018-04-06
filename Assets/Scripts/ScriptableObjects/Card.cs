using UnityEngine;

[CreateAssetMenu(fileName = " New Card", menuName = "Card")]
public class Card : ScriptableObject{

    public string owner;
    public string list;

    public int totalCost;

}
