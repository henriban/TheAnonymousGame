using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour {

    public Person person1;
    public Person person2;
    public Person person3;
    public Person person4;

    [SerializeField] Transform slots;

    private int turn = 0;

    [Header("Turn 1 (Sam, Taylor, Jamie, Cameron)")]
    public List<Sprite> recipts_Player1_Turn1;
    public List<Sprite> recipts_Player2_Turn1;
    public List<string> variables_Turn1;

    [Header("Turn 2")]
    public List<Sprite> recipts_Player1_Turn2;
    public List<Sprite> recipts_Player2_Turn2;
    public List<string> variables_Turn2;

    [Header("Turn 3")]
    public List<Sprite> recipts_Player1_Turn3;
    public List<Sprite> recipts_Player2_Turn3;
    public List<string> variables_Turn3;

    [Header("Turn 4")]
    public List<Sprite> recipts_Player1_Turn4;
    public List<Sprite> recipts_Player2_Turn4;
    public List<string> variables_Turn4;

    // Use this for initialization
    void Start() {

        Data.PersonModel1 = new PersonModel(person1);
        Data.PersonModel2 = new PersonModel(person2);
        Data.PersonModel3 = new PersonModel(person3);
        Data.PersonModel4 = new PersonModel(person4);

        GetNextTurn();
    }

    public void GetNextTurn() {
        turn++;
        switch (turn) {
            case 1:
                Data.ReciptsPlayer1 = recipts_Player1_Turn1;
                Data.ReciptsPlayer2 = recipts_Player2_Turn1;
                Data.Variables = variables_Turn1;
                break;
            case 2:
                Data.ReciptsPlayer1 = recipts_Player1_Turn2;
                Data.ReciptsPlayer2 = recipts_Player2_Turn2;
                Data.Variables = variables_Turn2;
                break;
            case 3:
                Data.ReciptsPlayer1 = recipts_Player1_Turn3;
                Data.ReciptsPlayer2 = recipts_Player2_Turn3;
                Data.Variables = variables_Turn3;
                break;
            case 4:
                Data.ReciptsPlayer1 = recipts_Player1_Turn4;
                Data.ReciptsPlayer2 = recipts_Player2_Turn4;
                Data.Variables = variables_Turn4;
                break;
        }
    }
}