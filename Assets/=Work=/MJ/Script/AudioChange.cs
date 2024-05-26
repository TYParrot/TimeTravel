// using UnityEngine;
// using System;

// public class AudioChange : MonoBehaviour
// {
//     public AudioSource audioSource;
//     public AudioClip successClip;
//     public AudioClip failureClip;

//     void OnEnable()
//     {
//         // 성공 및 실패 이벤트에 대한 리스너 등록
//         GameEvents.OnSuccess += PlaySuccessSound;
//         GameEvents.OnFailure += PlayFailureSound;
//     }

//     void OnDisable()
//     {
//         // 성공 및 실패 이벤트에 대한 리스너 제거
//         GameEvents.OnSuccess -= PlaySuccessSound;
//         GameEvents.OnFailure -= PlayFailureSound;
//     }

//     void PlaySuccessSound()
//     {
//         if (audioSource != null && successClip != null)
//         {
//             audioSource.clip = successClip;
//             audioSource.Play();
//         }
//     }

//     void PlayFailureSound()
//     {
//         if (audioSource != null && failureClip != null)
//         {
//             audioSource.clip = failureClip;
//             audioSource.Play();
//         }
//     }
// }
