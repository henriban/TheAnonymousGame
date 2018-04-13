using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class VariableDistributor : MonoBehaviour {

    public Text Var1, Var2, Var3, Var4, Var5, Var6, Var7, Var8;

    private List<string> personVars;

    void Start () {

        GeneratePersonVarList();
        AssignVars();
    }

    public void GeneratePersonVarList() {
        personVars = new List<string>();

        AddStrPersonVars(Data.PersonModel1);
        AddStrPersonVars(Data.PersonModel2);
        AddStrPersonVars(Data.PersonModel3);
        AddStrPersonVars(Data.PersonModel4);
    }

    private void AddStrPersonVars(PersonModel personModel) {
        foreach (string str in personModel.PickRandomVariables()) {
            personVars.Add(str);
        }
    }
    
    private void AssignVars() {
        System.Random rand = new System.Random();
        personVars.OrderBy(c => rand.Next()).ToList();

        Var1.text = personVars[0];
        Var2.text = personVars[1];
        Var3.text = personVars[2];
        Var4.text = personVars[3];
        Var5.text = personVars[4];
        Var6.text = personVars[5];
        Var7.text = personVars[6];
        Var8.text = personVars[7];
    }
}