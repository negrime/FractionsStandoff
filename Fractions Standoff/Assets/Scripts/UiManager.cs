using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private Text goldTxt;
    
    void Start()
    {
        
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 40, 20), "Text"))
        {
            Debug.Log("ok");
        }
    }

    void Update()
    {
        
    }

    public void SetGold(string value)
    {
        goldTxt.text = value;
    }
}
