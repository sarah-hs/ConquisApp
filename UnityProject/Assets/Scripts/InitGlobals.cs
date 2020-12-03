using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGlobals : MonoBehaviour
{
    public AudioClip click_clip;
    public AudioClip sceneSwitcher_clip;

    public Sprite musicOn_sprite;
    public Sprite musicOff_sprite;
    public Sprite soundsOn_sprite;
    public Sprite soundsOff_sprite;

    // Start is called before the first frame update
    void Start()
    {
        Globals.sprite_musicOn = musicOn_sprite;
        Globals.sprite_musicOff = musicOff_sprite;
        Globals.sprite_soundsOn = soundsOn_sprite;
        Globals.sprite_soundsOff = soundsOff_sprite;
        Globals.clip_click = click_clip;
        Globals.clip_sceneSwitcher = sceneSwitcher_clip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
