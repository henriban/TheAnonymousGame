using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class VarZoneDistributor : MonoBehaviour {

    public Transform varZonePanel;
    public GameObject variableSlot;
	public static int global_id;
	public GameObject var_prefab;

    private List<GameObject> variableSlotList = new List<GameObject>();
    private List<string> personVars;

    void Start () {
        GeneratePersonVarList();
        GenerateVariableSlots();
        PopulateVariableSlots();
		
		global_id = 0;
	}

	public void RemoveFromSlot(int index){
		variableSlotList [index].transform.DetachChildren ();
	}

	public void PopulateSlot(int index, string var_name){
		GameObject new_var = Instantiate (var_prefab);
		new_var.transform.SetParent (variableSlotList [index].transform);
		new_var.transform.GetChild (0).transform.GetComponent<Text> ().text = var_name;
		new_var.transform.localScale = new Vector3 (1, 1, 1);
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

			var.transform.name = "var" + global_id;

            Transform varText = var.transform.GetChild(0);
            varText.transform.GetComponent<Text>().text = personVars[i];
			global_id++;
        }

        //Data.VarZoneVariableSlots = variableSlotList;
    }
}
