using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Show the keyboard on game start and keep it visible until the end screen
        MobileKeyboardManager.Instance.KeepKeyboardVisible = true;
        MobileKeyboardManager.Instance.SetKeyboardVisibility(true);
    }
}
