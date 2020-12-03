using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioClip music;

    public Button button_music;
    public Button button_sounds;

    private AudioSource source_music;
    private AudioSource source_sounds;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] sources = GetComponents<AudioSource>();

        source_music = sources[0];
        source_music.clip = music;

        source_sounds = sources[1];

        if (Globals.mute_music) {
            source_music.Stop();
            button_music.GetComponent<Image>().sprite = Globals.sprite_musicOff;
        } else {
            source_music.Play();//playOnAwake = true;
            button_music.GetComponent<Image>().sprite = Globals.sprite_musicOn;
        }

        if (Globals.mute_sounds) {
            button_sounds.GetComponent<Image>().sprite = Globals.sprite_soundsOff;
        } else {
            button_sounds.GetComponent<Image>().sprite = Globals.sprite_soundsOn;
        }
    }

    public void stopMusic()
    {
        if (source_music.isPlaying) {
            Globals.mute_music = true;
            source_music.Pause();
            button_music.GetComponent<Image>().sprite = Globals.sprite_musicOff;
        } else {
            Globals.mute_music = false;
            source_music.Play();
            button_music.GetComponent<Image>().sprite = Globals.sprite_musicOn;
        }
    }

    public void muteSounds()
    {
        if (Globals.mute_sounds == false) {
            Globals.mute_sounds = true;
            button_sounds.GetComponent<Image>().sprite = Globals.sprite_soundsOff;
        } else {
            Globals.mute_sounds = false;
            button_sounds.GetComponent<Image>().sprite = Globals.sprite_soundsOn;
        }

        source_sounds.mute = Globals.mute_sounds;
    }

    public void playClick()
    {
        if (Globals.mute_sounds == false) {
            source_sounds.PlayOneShot(Globals.clip_click);
        }
    }
}