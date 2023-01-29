using UnityEngine;

public class WheelPointable : IWheelPointable
{
    Transform parent;
    Transform transform;
    Vector3 initialPosition;

    public WheelPointable(Transform transform)
    {
        this.transform = transform;
        initialPosition = transform.localPosition;
        parent = transform.parent;
    }

    public Vector3 Position { get { return parent.TransformPoint(initialPosition); } }

    public void ShiftPosition(Vector3 shift)
    {
        transform.position = parent.TransformPoint(initialPosition) + shift;
    }
}