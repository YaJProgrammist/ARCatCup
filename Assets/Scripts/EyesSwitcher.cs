using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesSwitcher : MonoBehaviour
{
    [SerializeField]
    private GameObject eyes;

    public void ShowEyes()
    {
        eyes.SetActive(true);
    }

    public void HideEyes()
    {
        eyes.SetActive(false);
    }
}
