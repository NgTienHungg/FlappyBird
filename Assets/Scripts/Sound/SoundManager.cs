using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance { get; private set; }

        [SerializeField] private List<Sound> listSounds;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            foreach (var sound in listSounds)
            {
                sound.source = gameObject.AddComponent<AudioSource>();
                sound.source.clip = sound.clip;
                sound.source.volume = sound.volume;
            }
        }

        public void PlaySound(string soundName)
        {
            var sound = listSounds.Find(s => s.name == soundName);
            sound.source.Play();
        }
        
        public void PlayOneShot(string soundName)
        {
            var sound = listSounds.Find(s => s.name == soundName);
            sound.source.PlayOneShot(sound.clip);
        }
    }
}