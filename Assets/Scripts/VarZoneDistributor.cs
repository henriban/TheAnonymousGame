using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

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

    public void NewTurn() {
        RemoveAllVariableSlots();
        GeneratePersonVarList();
        GenerateVariableSlots();
        PopulateVariableSlots();
    }

	public void HandleDropChange(){
		Debug.Log ("Dropped in varzone");
        CheckOfferButton();
	}

	public string RemoveFromSlot(int index){
		string name = variableSlotList [index].transform.GetChild (0).transform.GetChild (0).GetComponent<Text> ().text;
		variableSlotList [index].transform.DetachChildren ();

		return name;
	}

	public void PopulateSlot(int index, string var_name){

		int curr_index = 0;

		if (index == -1) {

			foreach (GameObject go in variableSlotList) {
				if (go.transform.childCount == 0) {
					index = curr_index;
					break;
				}
				curr_index++;
			}
		}

		GameObject new_var = Instantiate (var_prefab);
		new_var.transform.SetParent (variableSlotList [index].transform);
		new_var.transform.GetChild (0).transform.GetComponent<Text> ().text = var_name;
		new_var.transform.localScale = new Vector3 (1, 1, 1);
	}



    private void GeneratePersonVarList() {
        personVars = Data.Variables;

        //personVars = new List<string>();
        
        //AddPersonStrVars(Data.PersonModel1);
        //AddPersonStrVars(Data.PersonModel2);
        //AddPersonStrVars(Data.PersonModel3);
        //AddPersonStrVars(Data.PersonModel4);
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

    private void RemoveAllVariableSlots() {
        foreach(GameObject slot in variableSlotList) {
            Destroy(slot);
        }
        variableSlotList = new List<GameObject>();
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

    public void CheckOfferButton() {
        if (IsOfferButtonClikable()) {
            GameObject.Find("GameManger").GetComponent<DisplayOfferPanel>().SetOfferButtonClickable();
        }
        else {
            GameObject.Find("GameManger").GetComponent<DisplayOfferPanel>().SetOfferButtonNotClickable();
        }
    }

    //Check if it variable left in the VarZone
    private bool IsOfferButtonClikable() {
        foreach(GameObject slot in variableSlotList) {
            if(slot.transform.childCount > 0) {
                return false;
            }
        }
        return true;
    }
}
