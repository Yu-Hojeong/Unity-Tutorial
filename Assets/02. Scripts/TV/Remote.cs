using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Remote : MonoBehaviour
{
    public GameObject videoScreen;
    public Button[] buttonUI;
    public VideoClip[] clips;
    VideoPlayer videoPlayer;
    public bool isOn = false;
    public bool isMute = false;
    public int currentClipIndex = 0;


    void Awake()
    {
        videoPlayer = videoScreen.GetComponent<VideoPlayer>();
        videoPlayer.clip = clips[currentClipIndex];
    }

    void Start()
    {
        buttonUI[0].onClick.AddListener(OnScreenPower);
        buttonUI[1].onClick.AddListener(OnMute);
        buttonUI[2].onClick.AddListener(()=>OnChangeChannel(-1));
        buttonUI[3].onClick.AddListener(()=>OnChangeChannel(1));
    }
    public void OnScreenPower()
    {
        videoScreen.SetActive(!videoScreen.activeSelf);
    }
    public void OnMute()
    {
        isMute = !isMute;
        videoPlayer.SetDirectAudioMute(0, isMute);
    }

    public void OnChangeChannel(int i)
    {
        currentClipIndex = (currentClipIndex + i + clips.Length) % clips.Length;
        videoPlayer.clip = clips[currentClipIndex];
        
        
        videoPlayer.Play();
    }
    
}
