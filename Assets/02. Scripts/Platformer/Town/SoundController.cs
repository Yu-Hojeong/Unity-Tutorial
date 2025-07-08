using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    [SerializeField] AudioSource BgmAudio;
    [SerializeField] AudioSource EventAudio;
    [SerializeField] AudioClip[] audioClips;
    [SerializeField] Slider bgmVolume;
    [SerializeField] Slider eventVolume;
    [SerializeField] Toggle bgmMute;
    [SerializeField] Toggle eventMute;


    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        bgmVolume.value = BgmAudio.volume;
        eventVolume.value = EventAudio.volume;
        bgmMute.isOn = BgmAudio.mute;
        eventMute.isOn = EventAudio.mute;
    }

    void Start()
    {
        // audioSource = GetComponent<AudioSource>();
        BgmSound("TownBGM");
        bgmVolume.onValueChanged.AddListener(OnBgmVolumeChange); //매개변수가 float인 함수만 등록이 가능
        eventVolume.onValueChanged.AddListener(OnEventVolumeChange); //매개변수가 float인 함수만 등록이 가능

        bgmMute.onValueChanged.AddListener(OnBgmMute);
        eventMute.onValueChanged.AddListener(OnEventMute);
    }

    public void BgmSound(string clipName)
    {
        foreach (var clip in audioClips)
        {
            if (clip.name == clipName)
            {
                BgmAudio.clip = clip;
                BgmAudio.Play();
            }
        }

    }

    public void EventSound(string clipName)
    {
        foreach (var clip in audioClips)
        {
            if (clip.name == clipName)
            {

                EventAudio.PlayOneShot(clip);
            }
        }
    }

    void OnBgmVolumeChange(float volume)
    {
        BgmAudio.volume = volume;
    }
    void OnEventVolumeChange(float volume)
    {
        EventAudio.volume = volume;
    }
    void OnBgmMute(bool isMute)
    {
        BgmAudio.mute = isMute;
    }
    void OnEventMute(bool isMute)
    {
        EventAudio.mute = isMute;
    }
}
