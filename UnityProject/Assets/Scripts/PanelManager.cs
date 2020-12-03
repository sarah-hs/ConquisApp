using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject panel;
    bool active;

    public void openandclose()
    {
        if (active == false)
        {
            panel.transform.gameObject.SetActive(true);
            active = true;
        }
        else {
            panel.transform.gameObject.SetActive(false);
            active = false;
        }
    }
}