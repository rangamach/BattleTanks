using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private GameObject tank_prefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(tank_prefab,transform.position, Quaternion.identity);
    }
}
