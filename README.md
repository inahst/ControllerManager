# ControllerManager

So this package is used for managing up to 4 xbox 360 controllers in Unity in a simple and intuitive way.

To request a controller you simple call ControllerManager.getController(); The controller itself keeps track of its state,
which can be queried by [controller].isConnected().

Calls to buttons are formatted as follows:

[controller].ButtonPressed(Buttons.LeftShoulder)
            .ButtonReleased(Buttons.LeftShoulder)
            .Button(Buttons.LeftShoulder)
            
             
Calls to thumbsticks are:

[controller].GetStick(Sticks.Left)

And Triggers are

[controller].GetTrigger(Triggers.Left)
