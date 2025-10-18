using UnityEngine;
using Vuforia;

public class PlayAudioOnTarget : DefaultObserverEventHandler
{
    public AudioSource myAudio;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        if (myAudio != null && !myAudio.isPlaying)
        {
            myAudio.Play();
        }
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        if (myAudio != null && myAudio.isPlaying)
        {
            myAudio.Stop();
        }
    }
}
