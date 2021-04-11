using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycast2 : MonoBehaviour {
    public GameObject sphere;
    public GameObject Image;
    public GameObject ImageToOver;
    public Text changeText;
    public int initialScore;
    public GameObject button;
    public GameObject key;
    string btnName;

 
 void Update () {
  if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {	
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "myButton2":
                        sphere.SetActive(false);
                        key.SetActive(false);
				        Image.SetActive(false);
				        ImageToOver.SetActive(true);
				        initialScore += 70;
				        button.SetActive(true);
				    	changeText.text = "SCORE: 70";
				    	Debug.Log("Pressed");
                        break;
                    default:
                        break;

                }
            }
        }
        
 }
}