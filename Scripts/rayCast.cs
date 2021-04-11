using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rayCast : MonoBehaviour {
    public GameObject sphere;
    public Text changeText;
    public int initialScore;
    public GameObject button;
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
                    case "myButton1":
                        sphere.SetActive(false);
				        initialScore += 20;
				        button.SetActive(true);
				    	changeText.text = "SCORE: 20";
				    	Debug.Log("Pressed");
                        break;
                    default:
                        break;

                }
            }
        }
        
 }
}