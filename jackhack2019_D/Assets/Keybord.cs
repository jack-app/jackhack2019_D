using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keybord : MonoBehaviour
{
    const int MAX_LENGTH = 4;
    string inputtedName = "Name";

    void OnGUI()
    {
        this.inputtedName = GUI.TextField(new Rect(Screen.width / 2 - 50, Screen.height * 1 / 3, 100, 20), this.inputtedName, MAX_LENGTH);
    }


}
