using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openSettingsPanel : MonoBehaviour
{
   public GameObject Panel;

   public void openSettings(){
       if(Panel != null){
           bool isActive = Panel.activeSelf;
           Panel.SetActive(!isActive);
           Time.timeScale = 0f;
       }
   }
}
