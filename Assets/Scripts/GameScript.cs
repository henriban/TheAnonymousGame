using System.Collections.Generic;
using UnityEngine;


public class GameScript : MonoBehaviour {

    public Person person1;
    public Person person2;
    public Person person3;
    public Person person4;

    [SerializeField] Transform slots;

    [Header("Turn 1 (Sam, Taylor, Jamie, Cameron)")]
    public List<Sprite> recipts_Player1_Turn1;
    public List<Sprite> recipts_Player2_Turn1;

    [Header("Turn 2")]
    public List<Sprite> recipts_Player1_Turn2;
    public List<Sprite> recipts_Player2_Turn2;

    [Header("Turn 3")]
    public List<Sprite> recipts_Player1_Turn3;
    public List<Sprite> recipts_Player2_Turn3;

    [Header("Turn 4")]
    public List<Sprite> recipts_Player1_Turn4;
    public List<Sprite> recipts_Player2_Turn4;


    // Use this for initialization
    void Start() {

        Data.PersonModel1 = new PersonModel(person1);
        Data.PersonModel2 = new PersonModel(person2);
        Data.PersonModel3 = new PersonModel(person3);
        Data.PersonModel4 = new PersonModel(person4);

    }
}