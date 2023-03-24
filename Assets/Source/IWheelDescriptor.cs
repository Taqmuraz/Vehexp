using UnityEngine;

public interface IWheelDescriptor
{
    float TurnAngle { get; }
    ITorque Torque { get; }
    float Radius { get; }
    float DamperVelocity { get; }
    float DamperClamp { get; }
    Vector3 TorqueAxis { get; }
    Vector3 TurnAxis { get; }
    Vector3 PhysicsTorqueAxis { get; }
}
