using UnityEngine;

[System.Serializable]
public class WheelTorque : ITorque
{
    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float speed;

    public float Accelerate(float origin, float acceleration)
    {
        float speed = this.speed;
        if (Mathf.Sign(origin * acceleration) < 0f)
        {
            speed *= 5f;
        }
        return Mathf.Clamp(origin + acceleration * speed, min, max);
    }
}