# WinputManager
A simple library to access windows input API (such as system global hooks for input recording and simulate input events) easily using .Net (C#\VB .net).

## What is this?
WinputManager allows you to capture Windows common input (mouse and keyboard) easily. It works at system global level which means all of the low level input is being captured (By using the SetWindowsHookEx winapi).

It is the new library of [InputManager](https://www.codeproject.com/Articles/117657/InputManager-library-Track-user-input-and-simulate) (originally written for the commercial use of [Mouse Recorder Pro](http://byshynet.com/software.php?id=3)).

The current version only allows setting up hooks and listening to common user input (such as mouse & keyboard).
Input simulation is not yet supported.

## What's new in this version?
WinputManager allows you to perform the following:
* Recording mouse & keyboard input easily.
* Consume mouse and input events you wish not to be processed by the system.
* Code base was rebuilt - which means less bugs and a more reusable code flow.
* Exceptions are thrown when hooking fails


### Compiling and running this library
The library comes by default as a simple Windows Application. You can run it just as any .Net project.
Running it will open up an example window showing how to work with this library.

**In order to use this library in your project please change the WinputManager project Output type to Class library (right clicking on Solution Explorer > WinputManager > Properties > Output type > Class library).**

### Recording user input
Using WinputManager you can easily mouse and keyboard inputs such as: 
* mouse clicks
* keyboard typing
* mouse movements
* mouse scrolling

In order to the user input, you need to setup hooks using:
* KeyboardHook - a class reponsible of capturing keyboard events.
* MouseHook - a class reopnsible of capturing mouse events.

Your application will be notified by listening to any event the hook will raise.

KeyboardHook will only raise **OnKeyboardEvent(uint key, KeyState keyState)**.
MouseHook have 3 different events: 
* OnMouseMove(int x, int y)
* OnMouseEvent(int mouseEvent)
* OnMouseWheelEvent(int wheelValue)

**All of the events should return false if the event shouldn't be consumed or true if the event will be consumed.**
Returning true simply means that the system will stop delivering the input to target window\application.

Here is a simple example on how to use this library:
```csharp
KeyboardHook keyboardHook = new KeyboardHook();
MouseHook mouseHook = new MouseHook();

void InstallHooks() {
    // Setup keyboard hook
    keyboardHook.OnKeyboardEvent += KeyboardHook_OnKeyboardEvent;
    keyboardHook.Install();
    
    // Setup mouse hook
    mouseHook.OnMouseEvent += MouseHook_OnMouseEvent;
    mouseHook.OnMouseMove += MouseHook_OnMouseMove;
    mouseHook.OnMouseWheelEvent += MouseHook_OnMouseWheelEvent;
    mouseHook.Install();
}

void UninstallHooks() {
    keyboardHook.Uninstall();
    mouseHook.Uninstall();
}

private bool KeyboardHook_OnKeyboardEvent(uint key, BaseHook.KeyState keyState)
{
    Debug.WriteLine(String.Format("{0} key was {1}", 
        ((Keys) key).ToString(), 
        keyState == BaseHook.KeyState.Keydown ? "pressed" : "released"));

    return false;
}

private bool MouseHook_OnMouseWheelEvent(int wheelValue)
{
    Debug.WriteLine(String.Format("{0} mouse wheel value captured",
        (MouseHook.MouseWheelEvents) wheelValue).ToString());

    return false;
}

private bool MouseHook_OnMouseMove(int x, int y)
{
    Debug.WriteLine(String.Format("Mouse moved to: {0},{1}", x, y));
    return false;
}

private bool MouseHook_OnMouseEvent(int mouseEvent)
{
    Debug.WriteLine(String.Format("{0} mouse event occured", (MouseHook.MouseEvents) mouseEvent));
    return false;
}
```


