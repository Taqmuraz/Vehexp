using UnityEngine;

public interface IWheelDescriptor
{
    float TurnAngle { get; }
    float Toruqe { get; }
    float Radius { get; }
    float DamperVelocity { get; }
    Vector3 TorqueAxis { get; }
    Vector3 TurnAxis { get; }
}