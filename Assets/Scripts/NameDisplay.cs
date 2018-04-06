using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameDisplay : MonoBehaviour {

    public Person person;

    public Text personText;


    void Start() {

        personText.text = person.firstName;

    }
}
