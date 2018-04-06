using UnityEngine;


public class GameScript : MonoBehaviour {

    [SerializeField] Transform slots;

	// Use this for initialization
	void Start () {
        HasChanged();		
	}

    public void HasChanged() {
        foreach(Transform slotTransform in slots) {
            GameObject item = slotTransform.GetComponent<Slot>().item;
            if (item) {
                Debug.Log(item.name);
            }
        }
    }

}

namespace UnityEngine.EventSystems {
    public interface IHasChanged : IEventSystemHandler {
        void HasChanged();
    }
}