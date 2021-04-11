using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openTextInput : MonoBehaviour
{
	public GameObject Panel;

    public void openTextInputPanel(){
    	if(Panel != null){
    	   bool isActive = Panel.activeSelf;
           Panel.SetActive(!isActive);
           Time.timeScale = 0f;
    	}
    }
}
