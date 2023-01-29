using UnityEngine;

public class WheelPhysicsBody : IWheelPhysicsBody
{
    IPhysicsBody proxy;
    IWheelDescriptor descriptor;
    IVehicleDescriptor vehicleDescriptor;
    IWheelPointable pointable;

    public WheelPhysicsBody(IPhysicsBody proxy, IWheelDescriptor descriptor, IVehicleDescriptor vehicleDescriptor, IWheelPointable pointable)
    {
        this.proxy = proxy;
        this.descriptor = descriptor;
        this.vehicleDescriptor = vehicleDescriptor;
        this.pointable = pointable;
    }

    bool GroundContact(out float distance)
    {
        Vector3 up = vehicleDescriptor.UpAxis;
        float radius = descriptor.Radius;
        RaycastHit hit;
        if (Physics.Raycast(pointable.Position + up * radius, -up, out hit, radius * 2f))
        {
            distance = hit.distance;
            return true;
        }
        distance = radius * 2f;
        return false;
    }

    public Vector3 GetVelocity()
    {
        return proxy.GetVelocity();
    }

    public void AddVelocity(Vector3 velocity)
    {
        proxy.AddVelocity(velocity);
    }

    public void UpdatePhysics(IWheelState state)
    {
        float radius = descriptor.Radius;
        Vector3 up = vehicleDescriptor.UpAxis;
        float distance;
        
        Debug.DrawRay(pointable.Position, up, Color.green);

        if (GroundContact(out distance))
        {
            Vector3 velocity = proxy.GetVelocity();
            float vdot = Vector3.Dot(velocity, up) * 0.1f;
            float damperQ = Mathf.Max((descriptor.Radius * 2f - distance) / (descriptor.Radius * 2f) - vdot, 0f);
            Vector3 damper = up * damperQ * descriptor.DamperVelocity;
            proxy.AddVelocity(damper);
        }

        pointable.ShiftPosition(up * (radius * 2f - distance));
    }
}
