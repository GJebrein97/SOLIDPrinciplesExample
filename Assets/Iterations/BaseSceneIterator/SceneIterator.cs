using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneIterator : MonoBehaviour
{
    public int sceneIndex;
    public Button PreviousButton;
    public Button NextButton;
    public TextMeshProUGUI TitleText;
    public bool Loading;
    public List<string> PrincipleTitles;

    public void Start()
    {
        sceneIndex = 1;
        LoadScene(1, -1);

        PreviousButton.onClick.RemoveAllListeners();
        PreviousButton.onClick.AddListener(LoadPreviousScene);

        NextButton.onClick.RemoveAllListeners();
        NextButton.onClick.AddListener(LoadNextScene);
    }

    public void LoadPreviousScene()
    {
        if (Loading) return;

        var previousIndex = sceneIndex;
        sceneIndex--;

        if (sceneIndex <= 0)
            sceneIndex = SceneManager.sceneCountInBuildSettings - 1;

        LoadScene(sceneIndex, previousIndex);
    }

    public void LoadNextScene()
    {
        if (Loading) return;

        var previousIndex = sceneIndex;
        sceneIndex++;

        if (sceneIndex >= SceneManager.sceneCountInBuildSettings)
            sceneIndex = 1;

        LoadScene(sceneIndex, previousIndex);
    }


    public async void LoadScene(int nextSceneIndex, int previousSceneIndex)
    {
        Loading = true;
        SetPrincipleTitle(nextSceneIndex);

        List<AsyncOperation> loadList = new List<AsyncOperation>();

        if (IsAProperSceneIndex(nextSceneIndex))
            loadList.Add(SceneManager.LoadSceneAsync(nextSceneIndex, LoadSceneMode.Additive));

        if (IsAProperSceneIndex(previousSceneIndex))
            loadList.Add(SceneManager.UnloadSceneAsync(previousSceneIndex));

        await UniTask.WaitUntil(() =>
        {
            bool isDone = true;
            foreach (var load in loadList)
            {
                isDone = isDone && load.isDone;
            }
            return isDone;
        });

        Loading = false;
    }



    public bool IsAProperSceneIndex(int sceneIndex)
    {
        return sceneIndex >= 1 && sceneIndex < SceneManager.sceneCountInBuildSettings;
    }

    public void SetPrincipleTitle(int iterationNumber)
    {
        TitleText.text = PrincipleTitles[Mathf.Clamp(iterationNumber - 1, 0, PrincipleTitles.Count - 1)];
        TitleText.ForceMeshUpdate();
    }
}
