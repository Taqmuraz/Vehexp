using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerVehicle : MonoBehaviour
{
    [SerializeField] WheelGroup[] groups;
    IEnumerable<IWheel> wheels;
    IController controller;

    void Start()
    {
        controller = new PlayerVehicleController();
        IRelativePhysicsBody physicsBody = new RigidbodyPhysicsBody(gameObject);
        IVehicleDescriptor vehicleDescriptor = new VehicleDescritor(transform);
        wheels = groups.SelectMany(g => g.CreateWheels(vehicleDescriptor, physicsBody)).ToArray();
    }

    void Update()
    {
        foreach (var w in wheels) w.Update(controller);
    }

    void FixedUpdate()
    {
        foreach (var w in wheels) w.FixedUpdate();
    }
}
