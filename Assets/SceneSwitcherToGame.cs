using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(VideoPlayer))]
public class SceneSwitcherToGame : MonoBehaviour
{
    [SerializeField] private VideoPlayer _videoPlayer;

    private void OnEnable()
    {
        _videoPlayer = GetComponent<VideoPlayer>();
    }

    private void Update()
    {
        if (Time.frameCount > 100)
            if (_videoPlayer.isPlaying == false)
                LoadMainScene();

        if(Input.GetKeyDown(KeyCode.Space))
            LoadMainScene();
    }

    private void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }
}
