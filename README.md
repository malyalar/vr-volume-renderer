# ViVRe

## VIrtual reality Volume Renderer for Education

This Unity application and source allows a user to build an .apk that renders a CT Scan or MRI result in realtime 3D on android phones. The user can also slice and rotate the model as desired. Can be used by any institution that wishes to inexpensively allow students to study three-dimensional radiographs and complex anatomy slices. 

The default provided .apk is a medium-quality CT scan of a cadaveric foot, perfused with the BriteVu contrast agent. The use of virtual reality is thought to improve understanding of three-dimensional anatomy over the use of 2D media. The primary novelty of this application lies in the fact that this volume renderer can run on a mobile device at high framerate, and can provide students the ability to slice their anatomic models as they wish, removing the need for a large physical collection of expensive pre-sliced prosections.

## Totally Quality Screencapture Demo

![Low Quality Screencapture](VRVR.gif)

## Details

Based on user @mattatz's implementation of a volume renderer in Unity, this adaptation adds the following functionality:

1. Ability to add custom dicoms and rebuild the game to android (in-app dicom upload is not available currently).
2. Google Cardboard SDK is added for 3D viewing and manipulation of the dicom. All functions can be controlled using 
3. VERY basic functions to rotate and slice the model are present. Slice functions are identical to previous Unity implementation.
4. Resolved errors with the previous volume renderer implementation to render low-hounsfield values as black. In other words, parts that aren't bone will appear transparent, and thus the prism volume gameObject of the volume renderer in Unity can be moved to any scene and have the background scenery appear through bones and vessels and such.
5. A guide is included on how to convert dicoms to raw for @mattatz VolumeBuilderTool to parse properly. This bypasses his previous requirement to download cygwin (if on windows) and work with V^3, an arduous process. This guide uses the free software ImageJ. It is now significantly easier to import custom models into Unity.
