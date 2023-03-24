using UnityEngine;

public class VehiclePhysicsBody : IRelativePhysicsBody
{
    private class PointPhysicsBody : IPhysicsBody
    {
        Rigidbody rigidbody;
        Transform transform;
        Vector3 localPoint;

        public PointPhysicsBody(Rigidbody rigidbody, Vector3 localPoint)
        {
            transform = rigidbody.transform;
            this.rigidbody = rigidbody;
            this.localPoint = localPoint;
        }

        public Vector3 GetVelocity()
        {
            return rigidbody.GetPointVelocity(transform.TransformPoint(localPoint));
        }

        public void AddVelocity(Vector3 velocity)
        {
            rigidbody.AddForceAtPosition(velocity, transform.TransformPoint(localPoint), ForceMode.VelocityChange);
        }
    }

    Rigidbody rigidbody;

    public VehiclePhysicsBody(GameObject gameObject)
    {
        rigidbody = gameObject.AddComponent<Rigidbody>();
        //rigidbody.centerOfMass = Vector3.zero;
    }

    public IPhysicsBody Point(Vector3 point)
    {
        return new PointPhysicsBody(rigidbody, rigidbody.transform.InverseTransformPoint(point));
    }
}