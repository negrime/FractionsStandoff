using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public bool isReserved;
    private bool _isMouse;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1) && _isMouse)
        {
            isReserved = false;
            
        }
    }

    private void OnMouseEnter()
    {
        if (!isReserved)
        GetComponent<SpriteRenderer>().color = Color.green;

        _isMouse = true;

    }

    private void OnMouseExit()
    {
        if (!isReserved)
        GetComponent<SpriteRenderer>().color = Color.black;
        _isMouse = false;
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(1))
            isReserved = false;
        isReserved = true;
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    private void OnMouseOver()
    {
        if (!isReserved)
            GetComponent<SpriteRenderer>().color = Color.green;
    }
}
    
