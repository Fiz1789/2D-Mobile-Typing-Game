using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileKeyboardManager : MonoBehaviour
{
    public static MobileKeyboardManager Instance;
    TouchScreenKeyboard keyboard;
    Typer typer;
    string prevKeyboardText;

    /// <summary>
    /// Will show the keyboard again if you accidentally dismiss it
    /// </summary>
    public bool KeepKeyboardVisible { get; set; } = true;

    private void Awake()
    {
        // Set the singleton as we're probably going to have only one keyboard controller
        Instance = this;
        // Get typer reference
        typer = GameObject.FindGameObjectWithTag("Typer").GetComponent<Typer>();
    }

    void Start()
    {
        TouchScreenKeyboard.hideInput = true;
        // We set this to true in the game initializer
    }

    public void SetKeyboardVisibility(bool visible)
    {
        if (visible)
        {
            keyboard = TouchScreenKeyboard.Open(string.Empty);
        }
        else
        {
            KeepKeyboardVisible = false;
            keyboard.active = false;
        }
    }

    private void Update()
    {
        // reopen the keyboard if it closes
        if(KeepKeyboardVisible && keyboard.active == false)
        {
            SetKeyboardVisibility(true);
        }

        // Get the last text char and forward to input
        if(keyboard.text.Length > 0 && keyboard.text != prevKeyboardText)
        {
            typer.EnterLetter(keyboard.text[keyboard.text.Length - 1].ToString());
            prevKeyboardText = keyboard.text;
        }
        if (keyboard.text.Length > 30)
        {
            keyboard.text = string.Empty;
        }
    }
}
