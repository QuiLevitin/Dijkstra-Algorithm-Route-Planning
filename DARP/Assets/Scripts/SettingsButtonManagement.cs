using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingsButtonManagement : MonoBehaviour
{

    

    [SerializeField] private Slider sizeSlider;
    [SerializeField] private Slider edgeSlider;
    [SerializeField] private Slider pathSlider;
    
 


    void Start()
    {
        sizeSlider.value = PlayerPrefs.GetFloat("sizeSettings");
        edgeSlider.value = PlayerPrefs.GetFloat("edgeSettings");
        pathSlider.value = PlayerPrefs.GetFloat("pathSettings");
        


    }


    void Update()
    {
        

        PlayerPrefs.SetFloat("sizeSettings", sizeSlider.value); 
        PlayerPrefs.SetFloat("edgeSettings", edgeSlider.value); 
        PlayerPrefs.SetFloat("pathSettings", pathSlider.value); 



    }





}

 