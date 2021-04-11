using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnButon : MonoBehaviour
{
    public GameObject Panel;

    public void closeP(){
    	Panel.SetActive(false);
    }

    public void openP(){
    	Panel.SetActive(true);
    }
}
