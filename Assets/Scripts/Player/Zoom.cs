using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;

public class Zoom : MonoBehaviour
{
    public Locura loc;
    public CinemachineVirtualCamera cameraPJ;

    public float fov = 60;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            DOTween.To(() => fov, x => fov = x, 35, 1);
            cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 0.5f;
            cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 1f;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            DOTween.To(() => fov, x => fov = x, 60, 1);
            cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 0;
            cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 1;
        }

        if(loc.cordura <= 0.5f)
        {
            cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain += 0.01f;
            cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 1;
        }
        else
        {
            cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain -= 0.1f;
            cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 1;

        }

        cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = Mathf.Clamp(cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain, 0 , 2);


        cameraPJ.m_Lens.FieldOfView = fov;
    }
}
