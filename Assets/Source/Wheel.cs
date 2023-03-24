using UnityEngine;

public class Wheel : IWheel, IWheelState
{
    IWheelDescriptor descriptor;
    IRotatable rotatable;
    float torqueRotation;
    float torque;
    float turn;
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
        torque = descriptor.Torque.Accelerate(torque, controller.Acceleration * Time.deltaTime);
        turn = descriptor.TurnAngle * controller.Turn;
        torqueRotation += torque * Time.deltaTime * 360f;
        rotatable.Rotate(Quaternion.AngleAxis(turn, descriptor.TurnAxis) * Quaternion.AngleAxis(torqueRotation, descriptor.TorqueAxis));
    }

    public float Torque { get { return torque; } }
    public float Turn { get { return turn; } }
}
