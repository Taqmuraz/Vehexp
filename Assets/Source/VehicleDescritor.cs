using UnityEngine;

public class VehicleDescritor : IVehicleDescriptor
{
    Transform transform;

    public VehicleDescritor(Transform transform)
    {
        this.transform = transform;
    }

    public Vector3 VehicleToWorldPoint(Vector3 point)
    {
        return transform.TransformPoint(point);
    }

    public Vector3 VehicleToWorldDirection(Vector3 direction)
    {
        return transform.TransformDirection(direction);
    }
}
