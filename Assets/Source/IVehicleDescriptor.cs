using UnityEngine;

public interface IVehicleDescriptor
{
    Vector3 VehicleToWorldPoint(Vector3 point);
    Vector3 VehicleToWorldDirection(Vector3 direction);
}