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
        for(int i = 0; i < parentPanel.transform.childCount; i++) {
            if(parentPanel.transform.GetChild(i) != null) {
                Debug.Log(parentPanel.transform.GetChild(i).childCount);
                //Debug.Log(parentPanel.transform.GetChild(i).GetChild(0).GetComponent<Text>());
            }
        }
    }
}
