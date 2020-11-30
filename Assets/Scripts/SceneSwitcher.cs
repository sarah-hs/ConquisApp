using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string scene_name = "MainScene";
    private AudioSource source_sounds { get {return GetComponent<AudioSource>();} }

    private void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source_sounds.clip = Globals.clip_sceneSwitcher;
    }

    public void loadScene()
    {
        Debug.Log("Loading scene: " + scene_name);
        StartCoroutine(WaitSound(scene_name));
    }

    public void exitGame()
    {
        StartCoroutine(WaitToExit());
    }

    IEnumerator WaitSound(string scenename)
    {
        if (!Globals.mute_sounds) {
            source_sounds.PlayOneShot(Globals.clip_sceneSwitcher);
            yield return new WaitWhile(() => source_sounds.isPlaying);
        }
        SceneManager.LoadScene(scenename, LoadSceneMode.Single);
    }

    IEnumerator WaitToExit()
    {
        if (!Globals.mute_sounds)
        {
            source_sounds.PlayOneShot(Globals.clip_sceneSwitcher);
            yield return new WaitWhile(() => source_sounds.isPlaying);
        }
        Application.Quit();
    }
}