using UnityEngine;

public class WheelRotatable : IRotatable
{
    Transform transform;
    Quaternion initialRotation;

    public WheelRotatable(Transform transform)
    {
        this.transform = transform;
        initialRotation = transform.localRotation;
    }

    public void Rotate(Quaternion rotation)
    {
        transform.localRotation = initialRotation * rotation;
    }
}
