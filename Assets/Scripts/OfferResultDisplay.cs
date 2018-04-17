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

        RefreshDisplay();
        
    }

    public void RefreshDisplay() {

        resultText1.text = GenerateProsent(Data.PersonModel1);
        resultText2.text = GenerateProsent(Data.PersonModel2);
        resultText3.text = GenerateProsent(Data.PersonModel3);
        resultText4.text = GenerateProsent(Data.PersonModel4);

    }

    private string GenerateProsent(PersonModel person) {
        if(person.getNumberOfMatch() > 0 && person.AlignedVariables.Count > 0) {
            float x = person.getNumberOfMatch() / person.AlignedVariables.Count;
            return Randomenize((int)(x > 0 ? x * 100 : 0)) + "%";
        }
        return Randomenize(0) + "%";
    }

    private int Randomenize(int num) {
        
        if (num == 100) {
            num -= (int)Random.Range(0f, 4f);
        }else if(num == 0) {
            num += (int)Random.Range(0f, 6f);
        }
        else {
            num += (int)Random.Range(-10f, 10f);
        }
        return num;
    }
}
