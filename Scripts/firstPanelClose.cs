using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPanelClose : MonoBehaviour
{

    public GameObject Panel;
    public GameObject Canvas;
    
    public void closePanel(){
        if(Panel != null){
            Panel.SetActive(false);
            Canvas.SetActive(true);
        }
    }
}
