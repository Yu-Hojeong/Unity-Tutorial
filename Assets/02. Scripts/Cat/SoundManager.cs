using UnityEngine;
using UnityEngine.Rendering;

// namespace Cat
// {
    public class SoundManager : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip bgmClip;
        public AudioClip jumpClip;

        void Start()
        {
            SetBGMSound();
        }
        
        public void SetBGMSound()
        {
            audioSource.clip = bgmClip;
            audioSource.playOnAwake = true;
            audioSource.loop = true;
            
            audioSource.Play();
        }
        public void OnJumpSound()
        {
            audioSource.PlayOneShot(jumpClip);
        }
    }
// }


// public void SetBGMSound()
//         {
//             audioSource.clip = bgmClip; // 오디오 소스에 사운드 파일 설정
//             audioSource.playOnAwake = true; // 시작할 때 자동 재생
//             audioSource.loop = true; // 반복 기능
//             audioSource.volume = 0.1f; // 소리 음량
            
//             audioSource.Play(); // 시작
            
//             audioSource.Stop(); // 정지
//             audioSource.Pause(); // 일시정지
            
//         }