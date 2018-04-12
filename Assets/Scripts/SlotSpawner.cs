using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotSpawner : MonoBehaviour {

    public GameObject parentPanel;
    public GameObject slotPrefab;

    public void SpawnNewTurnOfSlots() {
        for(var i = 0; i < 8; i++) {
            Instantiate(slotPrefab, parentPanel.transform, parentPanel);
        }
    }
}
