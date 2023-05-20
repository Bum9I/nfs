using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    
    void Awake()
    {
        Instantiate(_prefab);
    }
}
