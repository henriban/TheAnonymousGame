using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateSlotManually : MonoBehaviour {

	public Transform dropZone;
	public Transform varZone;

	//If drop_index or var_index is -1 it means you have moved the card within the same zone

	public void PopulateSlot(int var_index, int drop_index, string name, bool varzone){
		GameObject go = GameObject.Find (name);
		VarZoneDistributor vargo = varZone.GetComponent<VarZoneDistributor> ();
		DropZoneManager dropgo = dropZone.GetComponent<DropZoneManager> ();

		if (varzone) {
			if (drop_index != -1) {
				dropgo.RemoveFromSlot (drop_index);
			}
			vargo.PopulateSlot (var_index, name);
		} else {
			if (var_index != -1) {
				vargo.RemoveFromSlot (var_index);
			}
			dropgo.PopulateSlot (drop_index, name);
		}
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			PopulateSlot (1, 0, "XD", false);
			PopulateSlot (0, 0, "Lol", false);
		}
	}

}
