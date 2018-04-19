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

    public List<string> AlignedVariables {
        get {
            return alignedVariables;
        }

        set {
            alignedVariables = value;
        }
    }

    public List<string> AllVariables {
        get {
            return allVariables;
        }

        set {
            allVariables = value;
        }
    }

    public List<string> UnusedList {
        get {
            return unusedList;
        }

        set {
            unusedList = value;
        }
    }

    public PersonModel(Person person, List<string> allVariables) {
        this.Person = person;
        //AllVariables = getAllPersonVariables(person);
        this.allVariables = allVariables;
        UnusedList = getAllPersonVariables(person);
        AlignedVariables = new List<string>();
    }

    private List<string> getAllPersonVariables(Person person) {
        return new List<string> {
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
    }


    public List<string> PickRandomVariables() {
        List<string> randomVariables = new List<string>();

        string str1 = UnusedList[(int)UnityEngine.Random.Range(0f, UnusedList.Count - 1f)];
        randomVariables.Add(str1);
        UnusedList.Remove(str1);

        string str2 = UnusedList[(int)UnityEngine.Random.Range(0f, UnusedList.Count - 1f)];
        randomVariables.Add(str2);
        UnusedList.Remove(str2);

        return randomVariables;
    }

    public void AddAlignedVariables(string str) {
        AlignedVariables.Add(str);
    }

    public int getNumberOfMatch() {
        int i = 0;

        foreach(string aligned in AlignedVariables) {
            if (allVariables.Contains(aligned)) {
                i++;
            }

            //foreach (string var in AllVariables ) {
            //    if (aligned.Equals(var)) {
            //        i++;
            //    }
            //}
        }

        return i;
    }
}