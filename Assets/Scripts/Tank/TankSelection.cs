using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankSelection : MonoBehaviour
{
    [SerializeField] private TankSpawner tank_spawner;

    public void GreenTankSelected()
    {
        tank_spawner.CreateTank(TankType.Green_Tank);
        this.gameObject.SetActive(false);
    }

    public void BlueTankSelected()
    {
        tank_spawner.CreateTank(TankType.Blue_Tank);
        this.gameObject.SetActive(false);
    }

    public void RedTankSelected()
    {
        tank_spawner.CreateTank(TankType.Red_Tank);
        this.gameObject.SetActive(false);
    }
}
