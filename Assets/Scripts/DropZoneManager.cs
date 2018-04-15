using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropZoneManager : MonoBehaviour {

    public GameObject parentPanel;
    public GameObject slotPrefab;

    void Start() {
        SpawnNewTurnOfSlots();
        HandleDropChang();
    }

    public void SpawnNewTurnOfSlots() {
        for(var i = 0; i < 8; i++) {
            
            GameObject slot = Instantiate(slotPrefab, parentPanel.transform, parentPanel);
            slot.transform.localScale = new Vector3(1, 1, 1);

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

                    int mod = i % 4;

                    if(mod == 0) {
                        Data.PersonModel1.AddAlignedVariables(str);
                        //Debug.Log("P1: " + Data.PersonModel1.getNumberOfMatch());
                    }
                    else if (mod == 1) {
                        Data.PersonModel2.AddAlignedVariables(str);
                        //Debug.Log("P2: " + Data.PersonModel2.getNumberOfMatch());
                    }
                    else if (mod == 2) {
                        Data.PersonModel3.AddAlignedVariables(str);
                        //Debug.Log("P3: " + Data.PersonModel3.getNumberOfMatch());
                    }
                    else if (mod == 3) {
                        Data.PersonModel4.AddAlignedVariables(str);
                        //Debug.Log("P4: " + Data.PersonModel4.getNumberOfMatch());
                    }
                }
            }
        }


        //checkShowOfferButton();
        
    }

    // Return true if all variables is distributed
    //private bool checkShowOfferButton() {
    //    foreach (GameObject slot in Data.VarZoneVariableSlots) {
    //        if (slot.transform.GetChild(0) != null) {
    //            return false;
    //        }
    //    }

    //    return true;
    //}
}
