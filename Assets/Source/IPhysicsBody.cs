using UnityEngine;

public interface IPhysicsBody
{
    Vector3 GetVelocity();
    void AddVelocity(Vector3 velocity);
}
