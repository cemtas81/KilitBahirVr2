
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
   
    public void SceneChange(int sceneNo)
    {
        SceneManager.LoadSceneAsync( sceneNo);
    }
}
