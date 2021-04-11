using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class firstArButton : MonoBehaviour
{
    public GameObject vButton;
    public GameObject sphere;
    public GameObject Image;
    public GameObject ImageToOver;
    public Text changeText;
    public int initialScore;
    public GameObject button;

    void Start(){
    	vButton = GameObject.Find("VirtualButton");
    	vButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
    	sphere.SetActive(false);
        Image.SetActive(false);
        ImageToOver.SetActive(true);
        initialScore += 20;
        button.SetActive(true);
    	changeText.text = "SCORE: "+initialScore;
    	Debug.Log("Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){

    }
}
