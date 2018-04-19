using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler {

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
            // Need a check because scroll view... 
            if (DragHandler.itemBeingDraged != null) {
                DragHandler.itemBeingDraged.transform.SetParent(transform);
            }
            
            //ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
         	
			if (gameObject.transform.parent.GetComponent<DropZoneManager> () != null) {
				gameObject.transform.parent.GetComponent<DropZoneManager> ().HandleDropChang ();
            } else {
				gameObject.transform.parent.GetComponent<VarZoneDistributor> ().HandleDropChange ();
			}

            GameObject.Find("VarZone").GetComponent<VarZoneDistributor>().CheckOfferButton();
        }
    }
}
