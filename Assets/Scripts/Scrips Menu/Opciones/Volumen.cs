using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{

    public Slider slider;
    public float sliderValue;
    public Image imagenMute;

    void Start()
    {

        slider.value = PlayerPrefs.GetFloat("VolumenAudio", 0.5f);
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();

    }

    public void ChangeSlider(float valor)
    {

        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();

    }

    public void RevisarSiEstoyMute()
    {

        if(slider.value == 0)
        {
            imagenMute.enabled = true;
        }
        else
        {
            imagenMute.enabled = false;
        }
    }
}
