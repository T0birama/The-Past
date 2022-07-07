using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;

public class Zoom : MonoBehaviour
{
    public GameObject Lupita;

    public CinemachineVirtualCamera cameraPJ;

    private float fov = 60;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            DOTween.To(() => fov, x => fov = x, 35, 1);
            cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 1;
            cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 2;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            DOTween.To(() => fov, x => fov = x, 60, 1);
            cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 0;
            cameraPJ.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 2;
        }

        if (fov == 35)
        {
            Lupita.SetActive(true);
        }
        else if (fov < 60)
        {
            Lupita.SetActive(false);
        }

        cameraPJ.m_Lens.FieldOfView = fov;
    }
}
