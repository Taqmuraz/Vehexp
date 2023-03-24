using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset = new Vector3(0f, 1f, -4f);

    void FixedUpdate()
    {
        Quaternion targetRotation = target.rotation;
        Vector3 targetPos = target.position + target.rotation * offset;
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.fixedDeltaTime * 5f);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.fixedDeltaTime * 5f);
    }
}
