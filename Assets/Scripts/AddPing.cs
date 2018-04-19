using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPing : MonoBehaviour {

    public Sprite check;
    public Sprite question;
    public Sprite disagree;
    public int btnClicked;
    private int lastClicked = 2;

	// Use this for initialization
	void Start () {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
	
	void TaskOnClick()
    {
        Debug.Log("Was called");

        string fieldToPopulate = "";

        GameObject t1 = transform.parent.parent.Find("Ping1").gameObject;
        GameObject t2 = transform.parent.parent.Find("Ping2").gameObject;

        if(t1.GetComponent<Image>().sprite == null)
        {
            fieldToPopulate = "Ping1";
        }
        else if(t2.GetComponent<Image>().sprite == null)
        {
            fieldToPopulate = "Ping2";
        }

        else
        {
            if(lastClicked == 2)
            {
                fieldToPopulate = "Ping1";
                lastClicked = 1;
            }
            else
            {
                fieldToPopulate = "Ping2";
                lastClicked = 2;
            }
        }

        GameObject t = transform.parent.parent.Find(fieldToPopulate).gameObject;

        Debug.Log(t.name);
        if(btnClicked == 0)
        {
            t.GetComponent<Image>().sprite = check;

            Color c = t.GetComponent<Image>().color;
            c.a = 255;
            t.GetComponent<Image>().color = c;
        }
        else if(btnClicked == 1)
        {
            t.GetComponent<Image>().sprite = disagree;
            Color c = t.GetComponent<Image>().color;
            c.a = 255;
            t.GetComponent<Image>().color = c;
        }
        else
        {
            t.GetComponent<Image>().sprite = question;
            Color c = t.GetComponent<Image>().color;
            c.a = 255;
            t.GetComponent<Image>().color = c;
        }
    }
}
