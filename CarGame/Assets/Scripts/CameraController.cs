using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Target, SelfTransform;

    private void LateUpdate()
    {
        SelfTransform.position = Vector3.Lerp(SelfTransform.position, Target.position + new Vector3(0, 0, -13), 0.2f);
    }
}
