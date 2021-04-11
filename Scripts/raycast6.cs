using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycast6 : MonoBehaviour {
    public GameObject sphere;
    public Text changeText;
    public int initialScore;
    public GameObject closedChest;
    public GameObject openChest;
    public GameObject canvas;
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
                    case "myButton6":
                        sphere.SetActive(false);
                        closedChest.SetActive(false);
                        openChest.SetActive(true);
                        canvas.SetActive(true);
				        initialScore += 20;
				    	changeText.text = "SCORE: 300";
				    	Debug.Log("Pressed");
                        break;
                    default:
                        break;

                }
            }
        }
        
 }
}