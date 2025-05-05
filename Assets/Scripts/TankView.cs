using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tank_controller;

    [SerializeField] private Rigidbody rigidbody;
    private float movement;
    private float rotation;

    public MeshRenderer[] tank_parts;

    private void Start()
    {
        GameObject main_camera = GameObject.Find("Main Camera");
        main_camera.transform.SetParent(transform);
        main_camera.transform.position = new Vector3(0f, 3f, -4f);
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");

        if (movement != 0)
            tank_controller.MoveTank(movement, tank_controller.GetTankModel().movement_speed);
        if (rotation != 0)
            tank_controller.RotateTank(rotation, tank_controller.GetTankModel().rotation_speed);
    }

    public void ChangeColor(Material new_color)
    {
        foreach(MeshRenderer mr in tank_parts)
            mr.material = new_color;
    }

    public void SetTankController(TankController controller)
    {
        tank_controller = controller;
    }

    public Rigidbody GetRigidbody()
    {
        return rigidbody;
    }
}
