using UnityEngine;
using TMPro;

public class CurrentLevelName : MonoBehaviour
{

    private TextMeshProUGUI t;
    private string currentLevelName;
    public GameFlowManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        t = this.GetComponent<TextMeshProUGUI>();
        currentLevelName = "level " + gameManager.currentId.ToString();
        t.text = currentLevelName;
    }

}
