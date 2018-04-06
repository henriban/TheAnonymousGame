using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

    public Card card;

    public Text ownerText;
    public Text listText;
    public Text totalCostText;

    void Start () {

        ownerText.text = card.owner;
        listText.text = card.list;
        totalCostText.text = card.totalCost.ToString() + "kr";

	}
}
