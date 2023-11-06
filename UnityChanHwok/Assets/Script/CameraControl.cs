using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject target;

    Vector3 defPosition;
    Quaternion defRotation; //Quaternion는 회전값에 대한 변수
    float defZoom;

    private void Start()
    {
        //기본 위치 저장
        defPosition = transform.position;
        defRotation = transform.rotation;
        defZoom = Camera.main.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        //마우스 왼쪽 드래그로 카메라 이동
        if(Input.GetMouseButton(0))
        {
            target.transform.Translate(
                -Input.GetAxis("Mouse X") / 10,  //GetAxis 
                Input.GetAxis("Mouse Y") / 10,
                0);
        }

        //마우스 오른쪽 드래그로 카메라 회전
        if(Input.GetMouseButton(1))
        {
            transform.Rotate(
                -Input.GetAxis("Mouse Y") * 10,
                -Input.GetAxis("Mouse X") * 10,
                0);
        }

        //휠회전으로 확대/축소
        if(Input.GetAxis("Mouse ScrollWheel") != 0)
            //노트북의 트라이페드로도 입력값을 받을 수 있다.
        {
            Camera.main.fieldOfView += (20 * Input.GetAxis("Mouse ScrollWheel"));
            if(Camera.main.fieldOfView <10)
                Camera.main.fieldOfView = 10;
            else if (Camera.main.fieldOfView >100)
                Camera.main.fieldOfView = 100;
        }

        //휠클릭으로 설정 초기화
        if(Input.GetMouseButton(2))
        {
            target.transform.position = defPosition;
            target.transform.rotation = defRotation;
            Camera.main.fieldOfView = defZoom;
        }
    }
}
