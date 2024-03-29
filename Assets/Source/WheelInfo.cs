﻿using UnityEngine;

[System.Serializable]
public class WheelInfo : IWheelDescriptor
{
    [SerializeField] float turnAngle = 30f;
    [SerializeField] WheelTorque torque;
    [SerializeField] float radius = 0.25f;
    [SerializeField] float damperForce = 0.1f;
    [SerializeField] float damperClamp = 0.1f;
    [SerializeField] Vector3 torqueAxis = new Vector3(1f, 0f, 0f);
    [SerializeField] Vector3 turnAxis = new Vector3(0f, 0f, 1f);
    [SerializeField] Vector3 physicsTorqueAxis = new Vector3(1f, 0f, 0f);

    public float TurnAngle { get { return turnAngle; } }
    public ITorque Torque { get { return torque; } }
    public Vector3 TorqueAxis { get { return torqueAxis; } }
    public Vector3 TurnAxis { get { return turnAxis; } }
    public float Radius { get { return radius; } }
    public float DamperVelocity { get { return damperForce; } }
    public float DamperClamp { get { return damperClamp; } }
    public Vector3 PhysicsTorqueAxis { get { return physicsTorqueAxis; } }
}
