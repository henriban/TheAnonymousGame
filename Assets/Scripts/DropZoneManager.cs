using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropZoneManager : MonoBehaviour {

    public GameObject parentPanel;
    public GameObject slotPrefab;
	private List<GameObject> slots = new List<GameObject>();
	public GameObject var_prefab;

    void Start() {
        SpawnNewTurnOfSlots();
        HandleDropChang();
    }

	public void RemoveFromSlot(int index){
		slots [index].transform.DetachChildren ();
	}

	public void PopulateSlot(int index, string var_name){
		RemoveFromSlot (index);
		GameObject new_var = Instantiate (var_prefab);
		new_var.transform.SetParent (slots [index].transform);
		new_var.transform.GetChild (0).transform.GetComponent<Text> ().text = var_name;
		new_var.transform.localScale = new Vector3 (1, 1, 1);
	}


    public void SpawnNewTurnOfSlots() {
        for(var i = 0; i < 8; i++) {
            
            GameObject slot = Instantiate(slotPrefab, parentPanel.transform, parentPanel);
            slot.transform.localScale = new Vector3(1, 1, 1);
			slots.Add (slot);
        }
    }

    public void HandleDropChang() {

        // Resets aligned variables
        Data.PersonModel1.AlignedVariables = new List<string>();
        Data.PersonModel2.AlignedVariables = new List<string>();
        Data.PersonModel3.AlignedVariables = new List<string>();
        Data.PersonModel4.AlignedVariables = new List<string>();

        for (int i = 0; i < parentPanel.transform.childCount; i++) {
            if(parentPanel.transform.GetChild(i) != null) {
                Transform slot = parentPanel.transform.GetChild(i);
                if(slot.transform.childCount > 0) {
                    Transform var = slot.transform.GetChild(0);
                    Transform textVar = var.transform.GetChild(0);
                    string str = textVar.GetComponent<Text>().text;

					int x = i % 4;
					int y = i / 4;


                    if(x == 0) {
                        Data.PersonModel1.AddAlignedVariables(str);
                        //Debug.Log("P1: " + Data.PersonModel1.getNumberOfMatch());
                    }
                    else if (x == 1) {
                        Data.PersonModel2.AddAlignedVariables(str);
                        //Debug.Log("P2: " + Data.PersonModel2.getNumberOfMatch());
                    }
                    else if (x == 2) {
                        Data.PersonModel3.AddAlignedVariables(str);
                        //Debug.Log("P3: " + Data.PersonModel3.getNumberOfMatch());
                    }
                    else if (x == 3) {
                        Data.PersonModel4.AddAlignedVariables(str);
                        //Debug.Log("P4: " + Data.PersonModel4.getNumberOfMatch());
                    }
                }
            }
        }


        //Debug.Log(checkShowOfferButton());
        
    }

    //Return true if all variables is distributed
    private bool checkShowOfferButton() {
        //for (int i = 0; i < parentPanel.transform.childCount; i++) {
        //    Transform var = parentPanel.transform.GetChild(i);
        //    if (var.GetChild(0) == null) {
        //        return false;
        //    }
        //}

        return true;
    }
}
