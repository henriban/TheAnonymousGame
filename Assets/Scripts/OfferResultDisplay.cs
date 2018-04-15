using UnityEngine;
using UnityEngine.UI;

public class OfferResultDisplay : MonoBehaviour {

    public Text personText1;
    public Text personText2;
    public Text personText3;
    public Text personText4;

    public Text resultText1;
    public Text resultText2;
    public Text resultText3;
    public Text resultText4;

    void Start() {

        Debug.Log("OfferResult");
        
        personText1.text = Data.PersonModel1.Person.firstName;
        personText2.text = Data.PersonModel2.Person.firstName;
        personText3.text = Data.PersonModel3.Person.firstName;
        personText4.text = Data.PersonModel4.Person.firstName;

        resultText1.text = GenerateProsent(Data.PersonModel1);
        resultText2.text = GenerateProsent(Data.PersonModel2);
        resultText3.text = GenerateProsent(Data.PersonModel3);
        resultText4.text = GenerateProsent(Data.PersonModel4);
    }

    private string GenerateProsent(PersonModel person) {
        //float x = person.AlignedVariables.Count / person.getNumberOfMatch();
        //return (x * 100) + "%";
        return "63%";
    }
}
