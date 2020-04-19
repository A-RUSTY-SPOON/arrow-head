using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelbuttons : MonoBehaviour
{
    public void backButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void testLevel()
    {
        SceneManager.LoadScene("Test level");
    }
}
