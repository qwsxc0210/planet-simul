using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    //  ���� ����!
    //  �� ���� ����ȴ�
    //  void Awake() -> 1��. �� �� ���� ����
    //  void OnEnable() -> ���� �� ����� �� ����
    //  void Start() -> OnEnable ����ǰ� ������ ���� ��

    //  ��� ����Ǵ� �Լ�
    //  void Update()

    public Vector3 RotateAxis = Vector3.up;
    public float RotateSpeed = 10.0f;

    private void Update()
    {
        //  Axis ? ��
        //  ȸ���� �׻� '�� (Axis)' �� �־�� ������ �� �ִ� (ȸ���� �� �ִ�)
        //  ������ (��뿣�� ���) �� �������� �ϱ� ������ x, y, z ���� ����� �� �ִ�
        //  2D �� x, y �� �ΰ�
        //  x -> Vector3.left, Vector3.right
        //  y -> Vector3.down, Vector3.up
        //  z -> Vector3.back, Vector3.forward

        transform.Rotate(RotateAxis, RotateSpeed * Time.deltaTime);

        //  ����Ƽ�� ���Ϸ� ��(Euler) + �����(Quaternion) �� ������ ����Ѵ�
        //  1. Euler ? -> ������ �̶�� ������ �ִ�
        //  - x, y, z ������ ���� ������ ȸ����ų �� �ִ� ����
        //  ���� ? ȸ�� ���� �˱� ���� (����Ƽ Inspector â���� ���̴� ȸ�� ���� �� ���̴�!)
        //  ���� ? ������ (�� ���� �� ���� ���� �� ����. ���ε��� �ϳ��� �����ش�)
        //  2. Quaternion ?
        //  - x, y, z, w. ���� + 1 ���� ��ŭ ���� �Ѱ� �� �÷��� ���
        //  ���� ? ������ ������ (�� ���� �����Ѵ�)
        //  ���� ? ���Ⱑ ��ƴ� (0 ~ 1)
        //  �׷���! ����Ƽ�� �� ���� Euler �� �̿��ϰ�, ������ Quaternion �� ����Ѵ�

        // Quaternion rotation = transform.rotation;
        // Quaternion addRotate = Quaternion.Euler(
        //                             RotateAxis.x * RotateSpeed,
        //                             RotateAxis.y * RotateSpeed,
        //                             RotateAxis.z * RotateSpeed);
        // transform.rotation = rotation * addRotate;
    }

}
