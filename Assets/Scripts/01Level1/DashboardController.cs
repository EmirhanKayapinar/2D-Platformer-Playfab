using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashboardController : MonoBehaviour
{

    DashboardPanelController _dash;
    [SerializeField] GameObject _dashboardPanel,_imagePanel,_usernamePanel;
    private void Awake()
    {
        _dash = new DashboardPanelController();
    }

    public void OpenDashboardPanelOnClick()
    {
        _dash.OpenDashboardPanel(_dashboardPanel);
    }

    public void CloseDashboardPanelOnClick()
    {
        _dash.CloseDashboardPanel(_dashboardPanel);
    }

    public void OpenImagePanelOnClick()
    {
        _dash.OpenImagePanel(_imagePanel);
    }

    public void CloseImagePanelOnClick()
    {
        _dash.CloseImagePanel(_imagePanel);
    }

    public void OpenUsernamePanelOnClick()
    {
        _dash.OpenUsernamePanel(_usernamePanel);
    }

    public void CloseUsernamePanelOnClick()
    {
        _dash.CloseUsernamePanel(_usernamePanel);
    }



}
