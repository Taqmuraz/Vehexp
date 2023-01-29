using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class WheelGroup
{
    [SerializeField] WheelInfo info;
    [SerializeField] GameObject[] gameObjects;

    public IEnumerable<IWheel> CreateWheels(IVehicleDescriptor vehicleDescriptor, IRelativePhysicsBody physicsBody)
    {
        return gameObjects.Select(g => new Wheel(info,
            new WheelPhysicsBody(physicsBody.Point(g.transform.position), info, vehicleDescriptor, new WheelPointable(g.transform)),
            new WheelRotatable(g.transform))).ToArray();
    }
}
