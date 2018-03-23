using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settingsmenu : MonoBehaviour {

	public AudioMixer audioMixer;

	public void SetVolume (float volume)
	{
		AudioMixer.SetFloat("Volume", Volume);
	}
}