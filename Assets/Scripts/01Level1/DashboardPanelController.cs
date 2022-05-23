using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashboardPanelController 
{
    public void OpenDashboardPanel(GameObject _dashboardPanel)
    {
        _dashboardPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseDashboardPanel(GameObject _dashboardPanel)
    {
        _dashboardPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void OpenImagePanel(GameObject _imagePanel)
    {
        _imagePanel.SetActive(true);
    }

    public void CloseImagePanel(GameObject _imagePanel)
    {
        _imagePanel.SetActive(false);
    }

    public void OpenUsernamePanel(GameObject _usernamePanel)
    {
        _usernamePanel.SetActive(true);

    }

    public void CloseUsernamePanel(GameObject _usernamePanel)
    {
        _usernamePanel.SetActive(false);

    }

}
