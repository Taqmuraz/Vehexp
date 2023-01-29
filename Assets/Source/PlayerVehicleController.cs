using UnityEngine;

public class PlayerVehicleController : IController
{
    public float Acceleration { get { return Input.GetAxis("Vertical"); } }
    public float Turn { get { return Input.GetAxis("Horizontal"); } }
}
