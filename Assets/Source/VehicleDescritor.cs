using UnityEngine;

public class VehicleDescritor : IVehicleDescriptor
{
    Transform transform;

    public VehicleDescritor(Transform transform)
    {
        this.transform = transform;
    }

    public Vector3 UpAxis { get { return transform.up; } }
}
