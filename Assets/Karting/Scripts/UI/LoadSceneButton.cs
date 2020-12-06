using UnityEngine;
using UnityEngine.SceneManagement;

namespace KartGame.UI
{
    public class LoadSceneButton : MonoBehaviour
    {
        [Tooltip("What is the name of the scene we want to load when clicking the button?")]
        public string SceneName;
        int nextLvId;
        int CurrentLvId;

        public void LoadTargetScene() 
        {
            SceneManager.LoadSceneAsync(SceneName);
        }
        public void LoadNextLv()
        {
            nextLvId = PlayerPrefs.GetInt("CurrentCompleteLv", 1) + 1;
            SceneManager.LoadSceneAsync("Lvl" + nextLvId.ToString());
        }
        public void LoadCurrentLv()
        {
            CurrentLvId = PlayerPrefs.GetInt("CurrentCompleteLv", 1);
            SceneManager.LoadSceneAsync("Lvl" + CurrentLvId.ToString());
        }
    }
}
