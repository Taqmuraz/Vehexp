using UnityEngine;

public interface IWheelPointable : IPointable
{
    void ShiftPosition(Vector3 shift);
}