using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject target;

    Vector3 defPosition;
    Quaternion defRotation; //Quaternion�� ȸ������ ���� ����
    float defZoom;

    private void Start()
    {
        //�⺻ ��ġ ����
        defPosition = transform.position;
        defRotation = transform.rotation;
        defZoom = Camera.main.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        //���콺 ���� �巡�׷� ī�޶� �̵�
        if(Input.GetMouseButton(0))
        {
            target.transform.Translate(
                -Input.GetAxis("Mouse X") / 10,  //GetAxis 
                Input.GetAxis("Mouse Y") / 10,
                0);
        }

        //���콺 ������ �巡�׷� ī�޶� ȸ��
        if(Input.GetMouseButton(1))
        {
            transform.Rotate(
                -Input.GetAxis("Mouse Y") * 10,
                -Input.GetAxis("Mouse X") * 10,
                0);
        }

        //��ȸ������ Ȯ��/���
        if(Input.GetAxis("Mouse ScrollWheel") != 0)
            //��Ʈ���� Ʈ�������ε� �Է°��� ���� �� �ִ�.
        {
            Camera.main.fieldOfView += (20 * Input.GetAxis("Mouse ScrollWheel"));
            if(Camera.main.fieldOfView <10)
                Camera.main.fieldOfView = 10;
            else if (Camera.main.fieldOfView >100)
                Camera.main.fieldOfView = 100;
        }

        //��Ŭ������ ���� �ʱ�ȭ
        if(Input.GetMouseButton(2))
        {
            target.transform.position = defPosition;
            target.transform.rotation = defRotation;
            Camera.main.fieldOfView = defZoom;
        }
    }
}
