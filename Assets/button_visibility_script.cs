using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_visibility_script : MonoBehaviour
{
    public GameObject button;
   
    private void OnMouseDown()
    {
        button.gameObject.SetActive(true);
    }
}
