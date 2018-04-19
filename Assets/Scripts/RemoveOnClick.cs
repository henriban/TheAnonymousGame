using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoveOnClick : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        Debug.Log("Clicked");
    }

    void TaskOnClick()
    {
        GetComponent<Image>().sprite = null;
        Color c = GetComponent<Image>().color;
        c.a = 0;
        GetComponent<Image>().color = c;
    }
}
