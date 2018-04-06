using System.Collections.Generic;

class PersonModel {

    private Person person;
    private List<string> allVariables;
    private List<string> unusedList;

    public PersonModel(Person person) {
        this.person = person;
        unusedList = getAllPersonVariables(person);
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

    //private void AddUsedVariable(List<string> usedVariables) {
    //    for (var i = 0; i < usedVariables.Count; i++) {
    //        usedList.Add(usedVariables[i]);
    //    }
    //}

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
        return person;
    }
}