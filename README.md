# YeetSpatializer

A Beat Saber mod that disables audio spatialization. This avoids log spam when playing on Linux through Proton.

## Dependencies

All dependencies can be installed from ModAssistant/BeatMods
* SiraUtil v3.0.0+

## Installation

* Download the latest version of the mod [here](https://github.com/jpdown/YeetSpatializer/releases).
* Place the dll in your Plugins folder

## Details

This mod hooks into the detection of old Windows versions, and force disables spatialization. This is because Proton reports Windows 10, but does not support HRTF.
