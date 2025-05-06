using UnityEngine;

public class TankController
{
    private TankModel tank_model;
    private TankView tank_view;

    private Rigidbody rigidbody;

    public TankController(TankModel model, TankView view)
    {
        tank_model = model;
        tank_view = GameObject.Instantiate<TankView>(view);

        tank_model.SetTankController(this);
        tank_view.SetTankController(this);

        rigidbody = tank_view.GetRigidbody();

        tank_view.ChangeColor(tank_model.tank_color);
    }

    public void MoveTank(float movement, float movement_speed)
    {
        rigidbody.velocity = tank_view.transform.forward * movement * movement_speed;
    }

    public void RotateTank(float rotation, float rotation_speed)
    {
        Vector3 vector = new Vector3(0f, rotation * rotation_speed, 0f);
        Quaternion delta_rotation = Quaternion.Euler(vector * Time.deltaTime);
        rigidbody.MoveRotation(rigidbody.rotation * delta_rotation);
    }

    public TankModel GetTankModel()
    {
        return tank_model;
    }

    public void Shoot(Transform fire_point, Rigidbody bomb_prefab)
    {
        Rigidbody bomb_instance = GameObject.Instantiate(bomb_prefab, fire_point.position, fire_point.rotation);
        bomb_instance.velocity = bomb_instance.transform.forward * tank_model.bomb_speed; 
    }
}
