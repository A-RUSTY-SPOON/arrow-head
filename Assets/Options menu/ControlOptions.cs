using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlOptions : MonoBehaviour
{
    public Slider VolumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        VolumeSlider.value = AudioListener.volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Volume(float volume)
    {
        AudioListener.volume = volume;
    }
    
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
