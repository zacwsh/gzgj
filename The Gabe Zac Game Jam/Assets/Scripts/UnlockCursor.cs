using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCursor : MonoBehaviour
{
    void UnlockAndShowCursor()
    {
        Cursor.lockState = CursorLockMode.None; // Unlock the cursor
        Cursor.visible = true; // Show the cursor
    }

    private void Awake()
    {
        UnlockAndShowCursor();
    }
}
