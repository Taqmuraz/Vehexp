using UnityEngine;

[System.Serializable]
public class WheelInfo : IWheelDescriptor
{
    [SerializeField] float turnAngle = 30f;
    [SerializeField] float torque = 1f;
    [SerializeField] float radius = 0.25f;
    [SerializeField] float damperForce = 0.1f;
    [SerializeField] Vector3 torqueAxis = new Vector3(1f, 0f, 0f);
    [SerializeField] Vector3 turnAxis = new Vector3(0f, 0f, 1f);

    public float TurnAngle { get { return turnAngle; } }
    public float Toruqe { get { return torque; } }
    public Vector3 TorqueAxis { get { return torqueAxis; } }
    public Vector3 TurnAxis { get { return turnAxis; } }
    public float Radius { get { return radius; } }
    public float DamperVelocity { get { return damperForce; } }
}
