using UnityEngine;

public class Wheel : IWheel
{
    IWheelDescriptor descriptor;
    Transform transform;
    float torque;
    float turn;
    Quaternion initialRotation;

    public Wheel(IWheelDescriptor descriptor, GameObject gameObject)
    {
        this.descriptor = descriptor;
        transform = gameObject.transform;
        initialRotation = transform.localRotation;
    }

    public void FixedUpdate()
    {
        transform.localRotation = initialRotation * Quaternion.AngleAxis(turn, descriptor.TurnAxis) * Quaternion.AngleAxis(torque, descriptor.TorqueAxis);
    }

    public void Update(IController controller)
    {
        turn = descriptor.TurnAngle * controller.Turn;
        torque += descriptor.Toruqe * controller.Acceleration;
    }
}
