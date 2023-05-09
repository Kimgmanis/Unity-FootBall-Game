using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    // Ref to audio mixer
    public AudioMixer audioMixer;
    // Ref to dropdown
    public TMP_Dropdown resolutionDropdown;

    // Array to store resolutions
    Resolution[] resolutions;

    public void Start()
    {
        // Collects resolutions
        resolutions = Screen.resolutions;
        // Clears dropdown
        resolutionDropdown.ClearOptions();
        // Creates a list of strings
        List<string> options = new List<string>();
        // Loop through each element in our resolutions array

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            // Formated string that displays resolution
            string option = resolutions[i].width + " x " + resolutions[i].height;
            // added to options list
            options.Add(option);

            // checks if the game resolution matches with the screen resolution
            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        // adds options list to resolution dropdown
        resolutionDropdown.AddOptions(options);
        // Initial game resolution
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    // Applies resolution
    public void setResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    // Use's exposed 'volume' parameter from audio mixer
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    // Graphics; low = 0, medium = 1, high = 2
    public void SetQuality (int qualityIndex)
    {
        // Changes quality settings based on the qualityIndex
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen (bool fullScreen)
    {
        Screen.fullScreen = fullScreen;
    }
}
