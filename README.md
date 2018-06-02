# ViVRe

## VIrtual reality Volume Renderer for anatomy Education

This Unity application and source allows a user to build an .apk that renders a CT Scan or MRI result in realtime 3D on android phones. The user can also slice and rotate the model as desired. Can be used by any institution that wishes to inexpensively allow students to study three-dimensional radiographs and complex anatomy slices. 

The default provided .apk is a medium-quality CT scan of a cadaveric foot, perfused with the BriteVu contrast agent. The use of virtual reality is thought to improve understanding of three-dimensional anatomy over the use of 2D media. The primary novelty of this application lies in the fact that this volume renderer can run on a mobile device at high framerate, and can provide students the ability to slice their anatomic models as they wish, removing the need for a large physical collection of expensive pre-sliced prosections. The Unity application can also easily be built to other hardware, such as the Vive.

## Totally High-Quality Screencapture

![Low Quality Screencapture](/Android builds and images/VRVR.gif)

## Details

Based on user [@mattatz's](https://github.com/mattatz/unity-volume-rendering) implementation of a volume renderer in Unity, this adaptation adds the following functionality:

1. Ability to add custom dicoms and rebuild the game to android (in-app dicom upload is not available currently).
2. Google Cardboard SDK is added for 3D viewing and manipulation of the dicom. All in-app functions can be controlled using the single button interface available with every standard GVR headset, for an extremely inexpensive VR experience.
3. VERY basic functions to rotate and slice the model are present. Slice functions are identical to previous Unity implementation.
4. Resolved errors with the previous volume renderer implementation to render low-hounsfield values as black. In other words, parts that aren't bone will now appear transparent, and thus the prism volume gameObject of the volume renderer in Unity can be moved to any scene and have the background scenery appear through bones/vessels/etc.
5. A guide is included on how to convert dicoms to raw for [@mattatz's](https://github.com/mattatz/unity-volume-rendering) VolumeAssetBuilder to parse properly. This bypasses his previous requirement to download cygwin (if on windows) and work with V^3, an arduous process. This guide uses the free software ImageJ. It is now significantly easier to import custom CT volumes into Unity.
6. Dicom image files can be edited within ImageJ before/after converting to .raw to isolate specific hounsfield ranges, crop the image stack (and hence the volume), and even doctor certain portions of the image (adding labels, colorizing, etc).

## More Screenshots

![Low Quality Screencapture](/Android builds and images/head and torso.png)
