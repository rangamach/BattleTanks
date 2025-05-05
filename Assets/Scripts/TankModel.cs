using UnityEngine;

public class TankModel
{
    private TankController tank_controller;

    public float movement_speed;
    public float rotation_speed;

    public TankModel(float move_speed, float rot_speed)
    {
        movement_speed = move_speed;
        rotation_speed = rot_speed;
    }

    public void SetTankController(TankController controller)
    {
        tank_controller = controller;
    }
}
