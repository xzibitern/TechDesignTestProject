using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnClick : MonoBehaviour   
{
    public string scene_name;

    void Start()
    {
       gameObject.SetActive(false);
    }
    public void OnClick()
    {
        SceneManager.LoadScene(scene_name);
    }
}
