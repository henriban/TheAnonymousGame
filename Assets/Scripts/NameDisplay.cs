using UnityEngine;
using UnityEngine.UI;

public class NameDisplay : MonoBehaviour {

    public Text personText1;
    public Text personText2;
    public Text personText3;
    public Text personText4;

    void Start() {
        
        personText1.text = Data.PersonModel1.Person.firstName;
        personText2.text = Data.PersonModel2.Person.firstName;
        personText3.text = Data.PersonModel3.Person.firstName;
        personText4.text = Data.PersonModel4.Person.firstName;

    }
}
