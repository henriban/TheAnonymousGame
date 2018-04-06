using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageDragAndDrop : MonoBehaviour {

    public int distanceToSnap = 100;

    void Update() {
        
    }

    public void Drag() {

        // store the position of the mouse and moves the object
        GameObject.Find("Card").transform.position = Input.mousePosition;
        
    }

    public void Drop() {

        for(int i = 1; i <= 3; i++) {
            GameObject ph1 = GameObject.Find("placeholder"+i);
            float distance = Vector3.Distance(GameObject.Find("Card").transform.position, ph1.transform.position);
            if (distance < distanceToSnap) {
                GameObject.Find("Card").transform.position = ph1.transform.position;
            }
        }
    }
}