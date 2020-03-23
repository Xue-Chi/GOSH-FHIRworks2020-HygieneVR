# GOSH-FHIRworks2020-HygieneVR
This HygieneVR package assists to **search patients basic information** including name, gender, date of birth and country by **searching** their unique **ID number** in the **VR environment**. **Oculus Quest** is recommended to implement rather than other devices.

## Deployment guide
Note: Under the premise of knowing the url and credentials, you are required to use this package.
### Choose suitable Unity version and install
This package is appropriate for Unity version 2019.3.0f5 or higher.
### Clone the repository and build
Clone this project and import it into unity.
Try building it onto the quest.
Hand tracking function will be provided for clicking buttons.

## Demonstration
Due to the lack of real devices, this demo will be presented in the simulator which is Unity platform.

<img width="683" alt="0" src="https://user-images.githubusercontent.com/43610529/77289683-57314480-6cd2-11ea-9581-43e2708b9b9e.png">

The image above is the main menu (homepage) of this project which consists of a title and a subtitle. After clicking the start button, you will enter a new scene like below shown.

<img width="682" alt="1" src="https://user-images.githubusercontent.com/43610529/77289689-5ac4cb80-6cd2-11ea-964e-66abc66f6c02.png">

Only by inputing the unique patient ID number in the blank field (example shown), fundamental information about name, gender, birth date and country will be replaced by the real data. You can search for any patient who is with an ID number.

## Future Use

This project can be modified easily by changing the url in the scripts such as searching for page number and observation of each patient. VR environment would replace the demo scene once it is connected to the hardware device (oculus quest) because all VR requirements have been set up already.



