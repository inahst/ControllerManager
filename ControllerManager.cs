using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public static class ControllerManager
{
    static int f = 30;
    static int[] itns = new int[4];
    static Controller[] controllers = new Controller[4];

    static ControllerManager()
    {
        int k = f;
        //controllers = new Controller[maxControllers];
        for (int i = 0; i < controllers.Length; i++)
        {
            controllers[i] = new Controller();
            controllers[i].index = i;
            Debug.Log(controllers[i].index);
        }
    }

    public static Controller getController()
    {
        foreach (Controller c in controllers)
        {
            if (c.connected == true && c.assigned == false)
            {
                c.assigned = true;
                return c;
            }
        }
        return null;
    }

    public static void ReleaseController(int index)
    {
        controllers[index].assigned = false;
    }
}