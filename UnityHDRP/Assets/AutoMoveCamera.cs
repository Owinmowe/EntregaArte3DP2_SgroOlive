using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveCamera : MonoBehaviour
{

    [SerializeField] float speed = 1;

    CinemachineTrackedDolly cmTrackedDolly = null;
    Animator cameraLookAnimation = null;

    private void Awake()
    {
        cameraLookAnimation = GetComponent<Animator>();
        cameraLookAnimation.SetFloat("Speed", speed);
        cmTrackedDolly = GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTrackedDolly>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cmTrackedDolly.m_PathPosition += Time.deltaTime * speed;
    }
}
