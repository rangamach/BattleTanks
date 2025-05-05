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
    }

    public List<Tank> tank_list;

    [SerializeField] private TankView tank_view;

    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tank_model = new TankModel(tank_list[2].movement_speed, tank_list[2].rotation_speed, tank_list[2].type, tank_list[2].color);
        TankController tank_controller = new TankController(tank_model, tank_view);
    }
}
