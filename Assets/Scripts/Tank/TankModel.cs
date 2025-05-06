using UnityEngine;

public class TankModel
{
    private TankController tank_controller;

    public float movement_speed;
    public float rotation_speed;

    public TankType tank_type;
    public Material tank_color;

    public float bomb_speed;

    public TankModel(float move_speed, float rot_speed, TankType type, Material color, float speed)
    {
        movement_speed = move_speed;
        rotation_speed = rot_speed;
        tank_type = type;
        tank_color = color;
        bomb_speed = speed;
    }

    public void SetTankController(TankController controller)
    {
        tank_controller = controller;
    }
}
