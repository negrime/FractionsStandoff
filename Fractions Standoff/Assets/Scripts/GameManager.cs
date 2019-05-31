using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Manager; // singleton
    [SerializeField]
    private UiManager _uiManager;
    [SerializeField]
    private int _buildingsCount; // кол-во зданий
    [SerializeField]
    private int _coefficient; // кол-вл голды которые прибавляем

    public int gold;
    
    void Start()
    {
        if (Manager == null)
            Manager = this;
        else if (Manager == this) 
            Destroy(gameObject);
        StartCoroutine(AddGold());

    }

    void Update()
    {
        
    }

    public IEnumerator AddGold()
    {
        if (_buildingsCount <= 1)
        {
            gold += _coefficient + _buildingsCount;
        }
        else
        {
            gold += _coefficient + _buildingsCount - 1 + _buildingsCount;
        }
        _uiManager.SetGold(gold.ToString());
        yield return new WaitForSeconds(10);
        StartCoroutine(AddGold());
        
    }

}
