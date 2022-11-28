using UnityEngine;

public class PreFinishBehavior : MonoBehaviour
{

    void Update()
    {
        //������� X ���������� ��������� �� �������� �������� �� 0
        float x = Mathf.MoveTowards(transform.position.x, 0, 2f * Time.deltaTime);
        float z = transform.position.z + 3f * Time.deltaTime;
        transform.position = new Vector3(x, 0, z);

        //������� �� Y �� �������� �������� �� 0
        float rot = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 0, Time.deltaTime * 100f);
        transform.localEulerAngles = new Vector3(0, rot, 0);
    }
}
