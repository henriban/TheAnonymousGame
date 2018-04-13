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
        
        personText1.text = Data.PersonModel1.Person.firstName;
        personText2.text = Data.PersonModel2.Person.firstName;
        personText3.text = Data.PersonModel3.Person.firstName;
        personText4.text = Data.PersonModel4.Person.firstName;

        // TODO: Maybe make own function in model to get %
        resultText1.text = Data.PersonModel1.getNumberOfMatch().ToString() + "%";
        resultText2.text = Data.PersonModel2.getNumberOfMatch().ToString() + "%";
        resultText3.text = Data.PersonModel3.getNumberOfMatch().ToString() + "%";
        resultText4.text = Data.PersonModel4.getNumberOfMatch().ToString() + "%";
    }
}
