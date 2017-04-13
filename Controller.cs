using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class Controller : MonoBehaviour
{
    public bool connected = false;
    public bool assigned = false;
    public int index = -1;
    bool stateChecked = false;
    bool prevSet = false;

    GamePadState state;
    GamePadState prevState;

    void Awake()
    {
        Debug.Log("hey");
    }

    void Update()
    {
        checkState();
        if (assigned && connected)
        {

        }
    }

    void LateUpdate()
    {
        stateChecked = false;
    }

    bool checkState()
    {
        GamePadState testState = GamePad.GetState((PlayerIndex)index);
        if (!testState.IsConnected)
            connected = false;
        else
        {
            connected = true;
            stateChecked = true;
            state = testState;
        }
        return connected;
    }

    public bool ButtonPressed(Buttons b)
    {
        if (prevSet)
            return XButton.buttonState(XGet.pressed, b, state, prevState);
        return false;
    }

    public bool ButtonReleased(Buttons b)
    {
        if (prevSet)
            return XButton.buttonState(XGet.released, b, state, prevState);
        return false;
    }

    public bool Button(Buttons b)
    {
        if (stateChecked)
            return XButton.buttonState(XGet.button, b, state, prevState);
        return false;
    }

    /*public bool TriggerReleased(Triggers t)
    {
        //throw new NotImplementedException();
    }

    public bool TriggerPressed(Triggers t)
    {
        //throw new NotImplementedException();
    }*/

    public float GetTrigger(Triggers t)
    {
        return XButton.GetTriggerValue(t, state);
    }

    public Vector2 GetStick(Sticks stick)
    {
        return XButton.GetStick(stick, state);
    }
}
