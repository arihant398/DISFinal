using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class noteTest : MonoBehaviour
{
 
    int n;
     public Text myText;
     public InputField myInputField;
   public void OnBP(){
      n++;
      Debug.Log(  n );
         myText.text = myInputField.text ;
   }
}