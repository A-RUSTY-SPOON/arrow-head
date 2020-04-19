using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void Level()
    {
        SceneManager.LoadScene("Level Select");
    }
    public void Options()
    {
        SceneManager.LoadScene("Options menu");
    }
}
