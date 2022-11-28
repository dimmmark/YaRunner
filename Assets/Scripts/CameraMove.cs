using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform Target;

    private void Start()
    {
        transform.parent = null;
    }

    void LateUpdate()
    {
        if (Target)
        {
            transform.position = Target.position;
        }
    }
}
