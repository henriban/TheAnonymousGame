using UnityEngine;


public class GameScript : MonoBehaviour {

    public Person person1;
    public Person person2;
    public Person person3;
    public Person person4;

    [SerializeField] Transform slots;

	// Use this for initialization
	void Start () {

        Data.PersonModel1 = new PersonModel(person1);
        Data.PersonModel2 = new PersonModel(person2);
        Data.PersonModel3 = new PersonModel(person3);
        Data.PersonModel4 = new PersonModel(person4);

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