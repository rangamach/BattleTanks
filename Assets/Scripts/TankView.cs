using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tank_controller;

    public void SetTankController(TankController controller)
    {
        tank_controller = controller;
    }
}
