using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class XButton
{
    public static bool buttonState(XGet get, Buttons button, GamePadState currentState, GamePadState prevState)
    {
        /* press/release logic
                    result = !((currentState.Buttons.LeftShoulder.ToString() == "Pressed") ^ GetPressed)
                        && !((prevState.Buttons.LeftShoulder.ToString() == "Released") ^ GetPressed);
        */
        bool result = false;
        switch (button)
        {
            case 0:
                if ((int)get == 2)
                    result = (currentState.Buttons.LeftShoulder.ToString() == "Pressed");
                else
                    result = !((currentState.Buttons.LeftShoulder.ToString() == "Pressed") ^ ((int)get == 0))
                        && !((prevState.Buttons.LeftShoulder.ToString() == "Released") ^ ((int)get == 0));
                break;
            /*case 1:
                result = !((currentState.Buttons.RightShoulder.ToString() == "Pressed") ^ GetPressed)
                        && !((prevState.Buttons.RightShoulder.ToString() == "Released") ^ GetPressed);
                break;
            case 2:
                result = !((currentState.Buttons.A.ToString() == "Pressed") ^ GetPressed)
                        && !((prevState.Buttons.A.ToString() == "Released") ^ GetPressed);
                break;
            case 3:
                result = !((currentState.Buttons.B.ToString() == "Pressed") ^ GetPressed)
                        && !((prevState.Buttons.B.ToString() == "Released") ^ GetPressed);
                break;
            case 4:
                result = !((currentState.Buttons.X.ToString() == "Pressed") ^ GetPressed)
                        && !((prevState.Buttons.X.ToString() == "Released") ^ GetPressed);
                break;
            case 5:
                result = !((currentState.Buttons.Y.ToString() == "Pressed") ^ GetPressed)
                        && !((prevState.Buttons.Y.ToString() == "Released") ^ GetPressed);
                break;
            case 6:
                result = !((currentState.Buttons.Start.ToString() == "Pressed") ^ GetPressed)
                        && !((prevState.Buttons.Start.ToString() == "Released") ^ GetPressed);
                break;
            case 7:
                result = !((currentState.Buttons.Back.ToString() == "Pressed") ^ GetPressed)
                        && !((prevState.Buttons.Back.ToString() == "Released") ^ GetPressed);
                break;
            case 8:
                result = !((currentState.DPad.Left.ToString() == "Pressed") ^ GetPressed)
                        && !((prevState.DPad.Left.ToString() == "Released") ^ GetPressed);
                break;
            case 9:
                result = !((currentState.DPad.Right.ToString() == "Pressed") ^ GetPressed)
                        && !((prevState.DPad.Right.ToString() == "Released") ^ GetPressed);
                break;
            case 10:
                result = !((currentState.DPad.Up.ToString() == "Pressed") ^ GetPressed)
                        && !((prevState.DPad.Up.ToString() == "Released") ^ GetPressed);
                break;
            case 11:
                result = !((currentState.DPad.Down.ToString() == "Pressed") ^ GetPressed)
                        && !((prevState.DPad.Down.ToString() == "Released") ^ GetPressed);
                break;
            case 12:
                result = !((currentState.Buttons.Guide.ToString() == "Pressed") ^ GetPressed)
                        && !((prevState.Buttons.Guide.ToString() == "Released") ^ GetPressed);
                break;
                */
        }
        return result;
    }

    public static Vector2 GetStick(Sticks s, GamePadState state)
    {
        Vector2 result = Vector2.zero;
        switch ((int)s)
        {
            case 0:
                result = new Vector2(state.ThumbSticks.Left.X, state.ThumbSticks.Left.Y);
                break;
            case 1:
                result = new Vector2(state.ThumbSticks.Right.X, state.ThumbSticks.Right.Y);
                break;
        }
        return result;
    }

    //public static bool Trigger(Triggers t, bool isGreater, float value, GamePadState currentState, GamePadState prevState)
    //{

    //}

    public static float GetTriggerValue(Triggers t, GamePadState currentState)
    {
        float result = 0;
        if (t == 0)
            result = currentState.Triggers.Left;
        else
            result = currentState.Triggers.Right;
        return result;
    }
    //{

    // }
}

public enum Buttons
{
    LeftShoulder,
    RightShoulder,
    A,
    B,
    X,
    Y,
    Start,
    back,
    dLeft,
    dRight,
    dUp,
    dDown,
    xbox,
    none
}

public enum Triggers
{
    left,
    right
}

public enum Sticks
{
    left,
    right
}

public enum XGet
{
    pressed,
    released,
    button
}
/*
public interface simpleButton
{
    bool Pressed(Buttons b);
    bool Released(Buttons b);
    bool TriggerReleased(Triggers t);
    bool TriggerPressed(Triggers t);
    float GetTrigger(Triggers t);
    Vector2 GetStick(Sticks stick);
    Vector2 GetStickValue(Sticks stick, Sticks axis);
}*/
