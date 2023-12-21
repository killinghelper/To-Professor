using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonctrl : MonoBehaviour
{
    public Transform barrelTransform; // ������ Transform ������Ʈ
    public float rotationSpeed = 10.0f; // ���� ȸ�� �ӵ�
    public float maxAngle = 30.0f; // �ִ� ����
    public float minAngle = -5.0f; // �ּ� ����

    void Update()
    {
        float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
        float angle = barrelTransform.localEulerAngles.x - mouseWheel * rotationSpeed;

        // ������ 360�� ������ ��ȯ
        if (angle > 180f) angle -= 360f;

        // ���� ����
        angle = Mathf.Clamp(angle, minAngle, maxAngle);

        barrelTransform.localEulerAngles = new Vector3(angle, barrelTransform.localEulerAngles.y, barrelTransform.localEulerAngles.z);
    }
}