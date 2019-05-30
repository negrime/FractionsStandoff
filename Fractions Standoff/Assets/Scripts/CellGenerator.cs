using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellGenerator : MonoBehaviour
{
    public Transform startPosition;
    public Transform parent;
    private Vector2 _position;
    public GameObject cell; 
    
    void Start()
    {
        _position = startPosition.position;
        for (int i = 0; i < 16; i++)
        {
            for (int j = 0; j < 16; j++)
            {
                var go = Instantiate(cell,  new Vector3(_position.x, _position.y, -0.1f), Quaternion.identity, parent);
                _position = new Vector2(_position.x + 1, _position.y);
            }
            _position = new Vector2(_position.x - 16, _position.y - 1);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
