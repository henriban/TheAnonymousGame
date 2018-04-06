using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VarDisplay : MonoBehaviour {

    public Person person1;
    public Person person2;
    public Person person3;
    public Person person4;

    //public Person[] persons;
    public List<Person> persons;

    public Text varText;

    void Start() {

        //varText.text = GetRandomVariable(PickRandomPerson());
        //varText.text = GetRandomVariable(person1);

        varText.text = "Variable";

        //PickRandomPerson();

        persons.Add(person1);
        persons.Add(person2);
        persons.Add(person3);
        persons.Add(person4);
    }

    private Person PickRandomPerson() {
        //int random = (int) UnityEngine.Random.Range(0f, 3f);
        //Debug.Log(random);
        return person1;
    }

    private string GetRandomVariable(Person person) {
        
        return person.Religion;
    }
}
