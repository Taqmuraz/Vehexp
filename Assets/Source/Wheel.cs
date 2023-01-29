using UnityEngine;

public class Wheel : IWheel, IWheelState
{
    IWheelDescriptor descriptor;
    IRotatable rotatable;
    float torqueRotation;
    float turnRotation;
    IWheelPhysicsBody physicsBody;

    public Wheel(IWheelDescriptor descriptor, IWheelPhysicsBody physicsBody, IRotatable rotatable)
    {
        this.descriptor = descriptor;
        this.rotatable = rotatable;
        this.physicsBody = physicsBody;
    }

    public void FixedUpdate()
    {
        physicsBody.UpdatePhysics(this);
    }

    public void Update(IController controller)
    {
        turnRotation = descriptor.TurnAngle * controller.Turn;
        torqueRotation += descriptor.Toruqe * controller.Acceleration * Time.deltaTime * 360f;
        rotatable.Rotate(Quaternion.AngleAxis(turnRotation, descriptor.TurnAxis) * Quaternion.AngleAxis(torqueRotation, descriptor.TorqueAxis));
    }

    public float TorqueRotation { get { return torqueRotation; } }
    public float TurnRotation { get { return turnRotation; } }
}
