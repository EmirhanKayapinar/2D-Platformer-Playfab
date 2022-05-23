using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLoginRegisterPanel : MonoBehaviour
{
    [SerializeField] GameObject _registerPanel, _loginPanel;
    public void SwitchPanel()
    {
        switch (_registerPanel.activeInHierarchy)
        {
            case true:
                _registerPanel.SetActive(false);
                _loginPanel.SetActive(true);
                break;
            default:
                _registerPanel.SetActive(true);
                _loginPanel.SetActive(false);
                break;
        }
    }
}
