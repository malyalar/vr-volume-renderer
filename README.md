# ViVRe
Virtual Reality Dicom Volume Renderer for Mobile Devices

![The mobile application](https://github.com/malyalar/ViVRe/VRVR.gif)

This Unity application and source allows a user to build an .apk that renders a CT Scan or MRI result in realtime 3D on android phones. The user can also slice and rotate the model as desired. Can be used by any institution that wishes to inexpensively allow students to study three-dimensional radiographs and complex anatomy slices. The default provided .apk is that of a foot imaged with the BriteVu contrast agent.

Based on user @mattatz's implementation of a volume renderer in Unity, this adaptation adds the following functionality:

1. Ability to add custom dicoms and rebuild the game to android (in-app dicom upload is not available currently).
2. Google Cardboard SDK is added for 3D viewing and manipulation of the dicom. All functions can be controlled using 
3. VERY basic functions to rotate and slice the model are present. Slice functions are identical to previous Unity implementation.
4. Resolved errors with the previous volume renderer implementation to render low-hounsfield values as black. In other words, parts that aren't bone will appear transparent, and thus the prism volume gameObject of the volume renderer in Unity can be moved to any scene and have the background scenery appear through bones and vessels and such.
5. A guide is included on how to convert dicoms to raw for @mattatz VolumeBuilderTool to parse properly. This bypasses his previous requirement to download cygwin (if on windows) and work with V^3, an arduous process. This guide uses the free software ImageJ. It is now significantly easier to import custom models into Unity.
