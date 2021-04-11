using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playGame : MonoBehaviour
{
    public GameObject Cube;

    public void openNewTarget(){
    	if(Cube != null){
    		Cube.SetActive(true);
    	}
    }
}
