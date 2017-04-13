using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestController : MonoBehaviour {
    //ControllerManager cmanager;
    TestManager manager;
    Controller c = null;
    bool hasController = false;
    public int index = -1;
	// Use this for initialization
	void Awake () {
       manager = GameObject.FindGameObjectWithTag("ControllerManager").GetComponent<TestManager>();
	}

    void checkController()
    {
        if (c == null)
        {
            //Debug.Log("test");
            c = manager.getController();
            if (c != null)
            {
                index = c.index;
                hasController = true;
            }
        }
    }

    void testInput()
    {
        //Debug.Log(c.Button(Buttons.LeftShoulder));
        if (c.ButtonPressed(Buttons.LeftShoulder))
        {
            Debug.Log(index + " pressed");
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (!hasController)
            checkController();
        else
            testInput();

	}
}
