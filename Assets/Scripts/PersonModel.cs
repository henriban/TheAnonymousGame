using System.Collections.Generic;

class PersonModel {

    private Person person;
    private List<string> allVariables;
    private List<string> unusedList;

    //ResultVariables
    private List<string> alignedVariables;

    public Person Person {
        get {
            return person;
        }

        set {
            person = value;
        }
    }

    public PersonModel(Person person) {
        this.Person = person;
        unusedList = getAllPersonVariables(person);
        alignedVariables = new List<string>();
    }

    private List<string> getAllPersonVariables(Person person) {
        allVariables = new List<string> {
            person.Jobb,
            person.Alder,
            person.Sivilstatus,
            person.Legning,
            person.Barn,
            person.Kjønn,
            person.Interesser,
            person.Høyde,
            person.Kroppsbygning,
            person.Bosted,
            person.Etnisitet,
            person.Religion,
            person.Parti,
            person.Familiemedlem,
            person.Fremkomstmiddel,
            person.Feriehus,
            person.ØkonomiskStatus,
            person.Fødselsdato,
            person.Epost,
            person.Tlfnr,
            person.Fødselssted,
            person.Sykdommer
        };

        return allVariables;
    }


    public List<string> PickRandomVariables() {
        List<string> randomVariables = new List<string>();

        string str1 = unusedList[(int)UnityEngine.Random.Range(0f, unusedList.Count - 1f)];
        string str2 = unusedList[(int)UnityEngine.Random.Range(0f, unusedList.Count - 1f)];

        randomVariables.Add(str1);
        randomVariables.Add(str2);

        unusedList.Remove(str1);
        unusedList.Remove(str2);

        return randomVariables;
    }

    public List<string> getAllVariables() {
        return allVariables;
    }

    public List<string> getUnusedList() {
        return unusedList;
    }

    public Person getPerson() {
        return Person;
    }

    public List<string> getAlignedVariables() {
        return alignedVariables;
    }

    public void AddAlignedVariables(string str) {
        alignedVariables.Add(str);
    }

    public void RemoveAlignedVariables(string str) {
        if (alignedVariables.Contains(str)) {
            alignedVariables.Remove(str);
        }
    }

    public int getNumberOfMatch() {
        int i = 0;

        foreach(string str in allVariables) {
            if (alignedVariables.Contains(str)) {
                i++;
            }
        }

        return i;
    }
}