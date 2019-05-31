using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Manager;
    
    void Start()
    {
        if (Manager == null)
            Manager = this;
        else if (Manager == this) 
            Destroy(gameObject);
    }

    void Update()
    {
        
    }

}
