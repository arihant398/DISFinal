using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycast4 : MonoBehaviour {
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
                    case "myButton4":
                        sphere.SetActive(false);
				        Image.SetActive(false);
				        key.SetActive(false);
				        ImageToOver.SetActive(true);
				        initialScore += 20;
				        button.SetActive(true);
				    	changeText.text = "SCORE: 170";
				    	Debug.Log("Pressed");
                        break;
                    default:
                        break;

                }
            }
        }
        
 }
}