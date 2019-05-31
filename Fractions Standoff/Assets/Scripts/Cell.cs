using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [Range(0, 1)]
    public float alpha;
    public bool isReserved;
    private bool _isMouse;
    private SpriteRenderer _spriteRenderer;
    private Color _defaultColor;
    
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _defaultColor = _spriteRenderer.color;
    }

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
            _spriteRenderer.color = _defaultColor;
        _isMouse = false;
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(1))
            isReserved = false;
        isReserved = true;
        _spriteRenderer.color = new Color(255, 0,0, alpha);
    }

    private void OnMouseOver()
    {
        if (!isReserved)
            _spriteRenderer.color = new Color(0, 255,0, alpha);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isReserved)
             _spriteRenderer.color = new Color(0, 255,0, alpha);
        else
        _spriteRenderer.color = new Color(255, 0,0, alpha);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _spriteRenderer.color = _defaultColor;
    }
}
    
