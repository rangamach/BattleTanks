using UnityEngine;

public class TankController
{
    private TankModel tank_model;
    private TankView tank_view;

    public TankController(TankModel model, TankView view)
    {
        tank_model = model;
        tank_view = view;

        tank_model.SetTankController(this);
        tank_view.SetTankController(this);

        GameObject.Instantiate(tank_view.gameObject);
    }
}
