using UnityEngine;

public class DisplayDescription : MonoBehaviour
{
    [SerializeField] GameObject descriptionPanel;

    private bool visible;

    // Start is called before the first frame update
    void Start()
    {
        visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (visible)
            descriptionPanel.SetActive(true);
        else descriptionPanel.SetActive(false);
    }

    public void toggleDisplay()
    {
        print("Description activée...");
        if (visible) visible = false;
        else visible = true;
    }
}
