using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public TankType type;
        public Material color;
        public float movement_speed;
        public float rotation_speed;
        public float bomb_speed;
    }

    public List<Tank> tank_list;

    [SerializeField] private TankView tank_view;

    public void CreateTank(TankType type)
    {
        switch(type)
        {
            case TankType.Blue_Tank:
            {
                TankModel tank_model = new TankModel(tank_list[1].movement_speed, tank_list[1].rotation_speed, tank_list[1].type, tank_list[1].color, tank_list[0].bomb_speed);
                TankController tank_controller = new TankController(tank_model, tank_view);
                break;
            }
            case TankType.Red_Tank:
            {
                TankModel tank_model = new TankModel(tank_list[2].movement_speed, tank_list[2].rotation_speed, tank_list[2].type, tank_list[2].color, tank_list[2].bomb_speed);
                TankController tank_controller = new TankController(tank_model, tank_view);
                break;
            }
            case TankType.Green_Tank:
            {
                TankModel tank_model = new TankModel(tank_list[0].movement_speed, tank_list[0].rotation_speed, tank_list[0].type, tank_list[0].color, tank_list[0].bomb_speed);
                TankController tank_controller = new TankController(tank_model, tank_view);
                break;
            }
        }
    }
}
