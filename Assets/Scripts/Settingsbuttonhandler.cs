using UnityEngine;

public class SettingsButtonHandler : MonoBehaviour
{
    public GameObject settingsPanel;

    public void OnSettingsClicked()
    {
        settingsPanel.SetActive(true);
    }

    public void OnBackButton()
    {
        settingsPanel.SetActive(false);
    }
}
