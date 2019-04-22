using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SetingsMenu : MonoBehaviour {

	public AudioMixer audioMixer;
	//public Dropdown resolutionDropdown;
	//Resolution[] resolutions;

	void Start(){
		/*resolutions = Screen.resolutions;
		resolutionDropdown.ClearOptions ();

		int currentResIndex = 0;
		List<string> options = new List<string>();
		for (int i = 0; i < resolutions.Length; i++) {
			string option = resolutions[i].width + " X " + resolutions[i].height;
			options.Add (option);

			if(resolutions[i].height == Screen.currentResolution.height &&
				resolutions[i].width == Screen.currentResolution.width
			){
				currentResIndex = i;
			}
		}

		resolutionDropdown.AddOptions (options);
		resolutionDropdown.value = currentResIndex;
		resolutionDropdown.RefreshShownValue ();
		*/
	}

	public void AdjustVolume(float volume){
		audioMixer.SetFloat ("volume",volume);
	}

	public void SetQuality(int qualityIndex){
		QualitySettings.SetQualityLevel (qualityIndex);
	}

	/*public void SetResolution(int resolutionIndex){
		Resolution resolution = resolutions[resolutionIndex];
		Screen.SetResolution(resolution.width,resolution.height,Screen.fullScreen);
	}
	*/
}
