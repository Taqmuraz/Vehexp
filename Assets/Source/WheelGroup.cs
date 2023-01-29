using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class WheelGroup
{
    [SerializeField] WheelInfo info;
    [SerializeField] GameObject[] gameObjects;

    public IEnumerable<IWheel> CreateWheels()
    {
        return gameObjects.Select(g => new Wheel(info, g)).ToArray();
    }
}
