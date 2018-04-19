using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PingManager : MonoBehaviour {

    public GameObject panel;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        GameObject go = GetPanelIfExist();

        if (go == null)
        {
            go = Instantiate(panel);
            go.transform.localPosition = new Vector3(go.transform.localPosition.x, go.transform.localPosition.y + 20, go.transform.localPosition.z + 15);
        }
        else
        {
            if (go.transform.parent == transform)
            {
                go.transform.parent = null;
                return;
            }
        }
        go.transform.SetParent(transform);
    }

    GameObject GetPanelIfExist()
    {
        GameObject gom = GameObject.FindGameObjectWithTag("VariableTag");

        return gom;
        
    }

}
