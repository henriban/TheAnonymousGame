using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class VarZoneDistributor : MonoBehaviour {

    public Transform varZonePanel;
    public GameObject variableSlot;

    private List<GameObject> variableSlotList = new List<GameObject>();
    private List<string> personVars;

    void Start () {
        GeneratePersonVarList();
        GenerateVariableSlots();
        PopulateVariableSlots();
	}

    private void GeneratePersonVarList() {
        personVars = new List<string>();
        
        AddPersonStrVars(Data.PersonModel1);
        AddPersonStrVars(Data.PersonModel2);
        AddPersonStrVars(Data.PersonModel3);
        AddPersonStrVars(Data.PersonModel4);
    }

    private void AddPersonStrVars(PersonModel personModel) {
        foreach (string str in personModel.PickRandomVariables()) {
            personVars.Add(str);
        }
    }

    private void GenerateVariableSlots() {
        for(int i = 0; i < 8; i++) {
            GameObject slot = Instantiate(variableSlot);
            
            slot.transform.SetParent(varZonePanel);
            slot.transform.localScale = new Vector3(1, 1, 1);

            variableSlotList.Add(slot);
        }
    }

    private void PopulateVariableSlots() {
        System.Random rand = new System.Random();
        personVars.OrderBy(c => rand.Next()).ToList();

        for(int i = 0; i < variableSlotList.Count; i++) {
            Transform var = variableSlotList[i].transform.GetChild(0);
            Transform varText = var.transform.GetChild(0);
            varText.transform.GetComponent<Text>().text = personVars[i];
        }

        //foreach (GameObject slot in variableSlotList) {
        //    Transform var = slot.transform.GetChild(0);
        //    Transform varText = var.transform.GetChild(0);

        //}
    }


}
