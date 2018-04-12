using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler {

    private PersonModel personModel;

    void SetUp(PersonModel personModel) {
        Debug.Log("Start");
        this.personModel = personModel;
    }

    public GameObject item {
        get {
            if(transform.childCount > 0) {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData) {

        if (!item) {   
            DragHandler.itemBeingDraged.transform.SetParent(transform);
            ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
            
            //Find string value to items droped in dropZone
            if (this.gameObject.tag == GameObject.FindGameObjectWithTag("Slot1").tag) {

                Debug.Log(DragHandler.itemBeingDraged.transform.GetChild(0).gameObject.GetComponent<Text>().text);
            }
        }
    }
}
