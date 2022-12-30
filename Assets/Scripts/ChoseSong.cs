using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoseSong : MonoBehaviour
{
    public TimeSet timeset;
    public void Choose(int songNum)
    {
        TimeSet.Song = songNum;
    }
    public void ChoosePlay(string name)
    {
        timeset.StopAllMusic();
        FindObjectOfType<AudioManager>().Play(name);
    }
}
