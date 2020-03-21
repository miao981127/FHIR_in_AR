# FHIR_in_AR
 Display FHIR Patient Data in AR Environment

# Setup
 Optimally, first download FHIR_in_AR.unitypackage. 
 Then in Unity Hub, create a new 3D project and import all the content in the package to use.
 
 Alternatively, clone this repository and manually exclude the unitypackage.
 In Unity Hub, add the folder to be a project and use.
 This may cause some sort of setting errors so the former one is preferred.
 
 For Windows users running Unity Version 2019, Compiler error may occur.
 Install multiplayer HLAPI and XR Legacy Input Helpers in package manager to resolve.
 
 If you have further questions, please refer to the Google AR Core Development Manual
 https://developers.google.com/ar/develop
  
 
# Description
 This package has mainly two types of templates, used respectively in \scenes\3dScene and \scenes\ARScene
 
 In 3dScene, the script would send a GET request to local host for patient data.
 A specialized json parser is used to read data from the json string and create objects from it.
 
 In ARScene, because the mobile device cannot get access to computer's localhost, patient data are pre-set just for demonstration.
 Created object can be linked to the scripts to be generated when the user touches the detected surface.
 This shows the collected data in the AR environment.
 
# Run
 For 3dScene, first run the FHIR API to open the local host port, then use play mode in Unity to preview.
 
 For ARScene, build the ARScene in Unity towards Android environment and get the apk file, or alternatively download test.apk from this repository
 
 Parpare a phone with AR Service for Google installed, install the apk file and run the app to see the demonstration.
