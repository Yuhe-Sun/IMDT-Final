using UnityEngine;
using TMPro;

public class CurrentLevelName : MonoBehaviour
{

    private TextMeshProUGUI t;
    private string currentLevelName;
    public GameFlowManager gfm;

    // Start is called before the first frame update
    void Start()
    {
        t = this.GetComponent<TextMeshProUGUI>();
        currentLevelName = "level " + gfm.currentId.ToString();
        t.text = currentLevelName;
    }

}
