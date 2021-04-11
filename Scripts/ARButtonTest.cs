using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ARButtonTest : MonoBehaviour
{
	string btnName;
	public Text testText;
    void Start()
    {
        
    }
    void Update()
    {
    	if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                if(btnName == "obj"){
                	testText.text = "Test: " + 10;
                }

            }
        }
        
    }
}
