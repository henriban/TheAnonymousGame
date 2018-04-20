using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPing : MonoBehaviour {

    public Sprite check;
    public Sprite question;
    public Sprite disagree;
    public int btnClicked;

	// Use this for initialization
	void Start () {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
	
	void TaskOnClick()
    {
        //Debug.Log("Was called");
        GameObject t = transform.parent.parent.Find("Ping1").gameObject;
        //Debug.Log(t.name);
        if(btnClicked == 0)
        {
            //Debug.Log("Sprite should be changed");
            //Debug.Log(check == null);
            t.GetComponent<Image>().sprite = check;

            Color c = t.GetComponent<Image>().color;
            c.a = 255;
            t.GetComponent<Image>().color = c;
        }
        else if(btnClicked == 1)
        {
            t.GetComponent<Image>().sprite = question;
        }
        else
        {
            t.GetComponent<Image>().sprite = disagree;
        }
    }
}
