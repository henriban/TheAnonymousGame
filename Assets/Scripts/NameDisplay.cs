using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameDisplay : MonoBehaviour {

    public Transform personPanel;

    public GameObject textObject;

    private List<string> allNames;

    void Start() {

        allNames = new List<string> {
            Data.PersonModel1.Person.firstName,
            Data.PersonModel2.Person.firstName,
            Data.PersonModel3.Person.firstName,
            Data.PersonModel4.Person.firstName
        };

        foreach(string name in allNames) {
            GameObject newPersonText = (GameObject)Instantiate(textObject);
            Text thePersonText = newPersonText.transform.GetComponent<Text>();

            thePersonText.text = name;

            newPersonText.transform.SetParent(personPanel);
            newPersonText.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
