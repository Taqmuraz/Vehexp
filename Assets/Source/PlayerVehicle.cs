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
        wheels = groups.SelectMany(g => g.CreateWheels()).ToArray();
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
