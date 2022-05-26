using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscPanelControl : MonoBehaviour
{
    [SerializeField] GameObject _escPanel;
    public void OpenEscPanel()
    {
        _escPanel.SetActive(true);
    }

    public void CloseEscPanel()
    {
        _escPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenEscPanel();
        }
    }
}
