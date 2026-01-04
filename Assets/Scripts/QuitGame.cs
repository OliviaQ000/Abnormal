using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class QuitGame : MonoBehaviour
{
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Application has Quit");
    }
}
