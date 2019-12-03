using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WabbitActuator : MonoBehaviour
{
    // Private Properties of a Wabbit

    private float movementSpeed = 10.0f;
    private float reactSpeed = 15.0f;

    [SerializeField]
    private GameObject Head;

    [SerializeField]
    private GameObject LeftEarBaseJoint;

    [SerializeField]
    private GameObject LeftEarJoint;

    [SerializeField]
    private GameObject RightEarBaseJoint;

    [SerializeField]
    private GameObject RightEarJoint;

    [SerializeField]
    private GameObject Background;

    [SerializeField]
    private float EarBaseRotationSpeed = 30.0f;
    private float EarEndRotationSpeed = 30.0f;

    private float UpLeftEarBaseTargetAngle = 15.0f;
    private float UpLeftEarTargetAngle = 10.0f;
    private float UpRightEarBaseTargetAngle = 160.0f;
    private float UpRightEarTargetAngle = 10.0f;
    private float DownLeftEarBaseTargetAngle = 45.0f;
    private float DownLeftEarTargetAngle = 0.0f;
    private float DownRightEarBaseTargetAngle = 45.0f;
    private float DownRightEarTargetAngle = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am alive!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * movementSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            MoveWabbit("Up");
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveWabbit("Down");
        }

    }

    private void MoveWabbit(string wabbitDirection)
    {
        switch (wabbitDirection)
        {
            case "Up":
                Debug.Log("Case Up");
                MoveEarsUp();
                transform.position += transform.up * reactSpeed * Time.deltaTime;
                break;
            case "Down":
                Debug.Log("Case Down");
                MoveEarsDown();
                transform.position -= transform.up * reactSpeed * Time.deltaTime;
                break;
        }
    }

    private void MoveEarsUp()
    {
        Quaternion leftEarBaseRot = LeftEarBaseJoint.transform.localRotation;
        Quaternion leftEarEndRot = LeftEarJoint.transform.localRotation;

        Vector3 leftEarBaseRotEuler = leftEarBaseRot.eulerAngles;
        Vector3 leftEarEndRotEuler = leftEarEndRot.eulerAngles;

        if (!Mathf.Approximately(leftEarBaseRotEuler.x, UpLeftEarBaseTargetAngle))
        {
            float deltaAngle = UpLeftEarBaseTargetAngle - leftEarBaseRotEuler.x;
            Vector3 localRotationAxis = LeftEarBaseJoint.transform.InverseTransformVector(Vector3.right);

            LeftEarBaseJoint.transform.Rotate(localRotationAxis, deltaAngle * EarBaseRotationSpeed * Time.deltaTime);
        }

        if (!Mathf.Approximately(leftEarEndRotEuler.x, UpLeftEarTargetAngle))
        {
            float deltaAngle = UpLeftEarTargetAngle - leftEarEndRotEuler.x;
            Vector3 localRotationAxis = LeftEarJoint.transform.InverseTransformVector(Vector3.right);

            LeftEarJoint.transform.Rotate(localRotationAxis, deltaAngle * EarEndRotationSpeed * Time.deltaTime);
        }

        Quaternion rightEarBaseRot = RightEarBaseJoint.transform.localRotation;
        Quaternion rightEarEndRot = RightEarJoint.transform.localRotation;

        Vector3 rightEarBaseRotEuler = rightEarBaseRot.eulerAngles;
        Vector3 rightEarEndRotEuler = rightEarEndRot.eulerAngles;

        if (!Mathf.Approximately(rightEarBaseRotEuler.x, UpRightEarBaseTargetAngle))
        {
            float deltaAngle = UpRightEarBaseTargetAngle - rightEarBaseRotEuler.x;
            Vector3 localRotationAxis = RightEarBaseJoint.transform.InverseTransformVector(Vector3.right);

            RightEarBaseJoint.transform.Rotate(localRotationAxis, deltaAngle * EarBaseRotationSpeed * Time.deltaTime);
        }

        if (!Mathf.Approximately(rightEarEndRotEuler.x, UpRightEarTargetAngle))
        {
            float deltaAngle = UpRightEarTargetAngle - rightEarEndRotEuler.x;
            Vector3 localRotationAxis = RightEarJoint.transform.InverseTransformVector(Vector3.right);

            RightEarJoint.transform.Rotate(localRotationAxis, deltaAngle * EarEndRotationSpeed * Time.deltaTime);
        }
    }

    private void MoveEarsDown()
    {
        Quaternion leftEarBaseRot = LeftEarBaseJoint.transform.localRotation;
        Quaternion leftEarEndRot = LeftEarJoint.transform.localRotation;

        Vector3 leftEarBaseRotEuler = leftEarBaseRot.eulerAngles;
        Vector3 leftEarEndRotEuler = leftEarEndRot.eulerAngles;

        if (!Mathf.Approximately(leftEarBaseRotEuler.x, DownLeftEarBaseTargetAngle))
        {
            float deltaAngle = DownLeftEarBaseTargetAngle - leftEarBaseRotEuler.x;
            Vector3 localRotationAxis = LeftEarBaseJoint.transform.InverseTransformVector(Vector3.right);

            LeftEarBaseJoint.transform.Rotate(localRotationAxis, deltaAngle * EarBaseRotationSpeed * Time.deltaTime);
        }

        if (!Mathf.Approximately(leftEarEndRotEuler.x, DownLeftEarTargetAngle))
        {
            float deltaAngle = DownLeftEarTargetAngle - leftEarEndRotEuler.x;
            Vector3 localRotationAxis = LeftEarJoint.transform.InverseTransformVector(Vector3.right);

            LeftEarJoint.transform.Rotate(localRotationAxis, deltaAngle * EarEndRotationSpeed * Time.deltaTime);
        }

        Quaternion rightEarBaseRot = RightEarBaseJoint.transform.localRotation;
        Quaternion rightEarEndRot = RightEarJoint.transform.localRotation;

        Vector3 rightEarBaseRotEuler = rightEarBaseRot.eulerAngles;
        Vector3 rightEarEndRotEuler = rightEarEndRot.eulerAngles;

        if (!Mathf.Approximately(rightEarBaseRotEuler.x, DownRightEarBaseTargetAngle))
        {
            float deltaAngle = DownRightEarBaseTargetAngle - rightEarBaseRotEuler.x;
            Vector3 localRotationAxis = RightEarBaseJoint.transform.InverseTransformVector(Vector3.right);

            RightEarBaseJoint.transform.Rotate(localRotationAxis, deltaAngle * EarBaseRotationSpeed * Time.deltaTime);
        }

        if (!Mathf.Approximately(rightEarEndRotEuler.x, DownRightEarTargetAngle))
        {
            float deltaAngle = DownRightEarTargetAngle - rightEarEndRotEuler.x;
            Vector3 localRotationAxis = RightEarJoint.transform.InverseTransformVector(Vector3.right);

            RightEarJoint.transform.Rotate(localRotationAxis, deltaAngle * EarEndRotationSpeed * Time.deltaTime);
        }
    }
}
