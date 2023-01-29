using UnityEngine;

public interface IRotatable
{
    void Rotate(Quaternion rotation);
    Quaternion Rotation { get; }
}
