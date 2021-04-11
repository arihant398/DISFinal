using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    public Text changeText;
    public int initialScore;

    public void updateScore(){
    	initialScore += 20;
    	changeText.text = "SCORE: "+initialScore;
    }
}
