using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public GameObject Panel;

    public void openInventory(){
    	Panel.SetActive(true);
    }

    public void closeInventory(){
    	Panel.SetActive(false);
    }
}
