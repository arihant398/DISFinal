using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class virtualButton : MonoBehaviour
{
    public GameObject vButton;
    public GameObject sphere;
    public Text testText;
    public GameObject Image;

    void Start(){
    	vButton = GameObject.Find("VirtualButton");
    	vButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
    	sphere.SetActive(false);
        testText.text = "Test: LOL: "+10;
        Image.SetActive(true);
    	Debug.Log("Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){

    }
}
