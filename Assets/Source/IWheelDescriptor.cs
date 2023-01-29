using UnityEngine;

public interface IWheelDescriptor
{
    float TurnAngle { get; }
    float Toruqe { get; }
    Vector3 TorqueAxis { get; }
    Vector3 TurnAxis { get; }
}
