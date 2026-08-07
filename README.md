# Musical Auditorium VR

An immersive VR concert experience built in Unity, featuring interactive musical instruments, spatial audio positioning, and real-time audience simulation.

## Overview

Musical Auditorium VR lets players step into a virtual concert hall and physically play real instruments using motion-based hand and controller interactions. Instrument sounds respond dynamically to how hard and fast you play, creating a natural, physics-driven performance experience.

## Features

- **Interactive Instruments** — Play a piano, drum set, and xylophone, each with realistic sound sets
- **Physics-Based Audio** — Pitch and volume of instrument sounds are dynamically randomized based on the force applied through hand/controller movement
- **Spatial Audio Positioning** — Realistic 3D sound placement across the auditorium environment
- **Real-Time Audience Simulation** — Simulated audience presence for an authentic concert atmosphere
- **Microphone Interaction** — Vocal/mic component as part of the performance setup
- **Full VR Locomotion** — Smooth movement and rotation via joystick controls

## Controls

| Action | Input |
|---|---|
| Grab drum/xylophone sticks | Grab Trigger |
| Rotate | Left Joystick |
| Move through environment | Right Joystick |
| Play piano | Ray Interactor + Pinch Trigger |

## Tech Stack

- **Engine:** Unity 2022.3.50f1
- **Framework:** XR Interaction Toolkit
- **Tested Devices:** HTC Vive Pro, Meta Quest 2

## Instruments

- **Piano** — Played via ray interactors with pinch triggers; real piano sound samples
- **Drum Set** — Grab-based stick interaction; real drum sound samples
- **Xylophone** — Grab-based stick interaction with force-responsive audio
- **Microphone** — Vocal interaction component

## How Force-Based Audio Works

Instrument sounds are not static triggers. The velocity/force of hand or controller movement at the moment of contact is captured and mapped to both pitch and volume, so gentle taps sound softer and quieter while harder hits sound louder and sharper — closely mimicking how real acoustic instruments behave.

## Getting Started

1. Clone or download the project
2. Open in Unity 2022.3.50f1
3. Ensure XR Interaction Toolkit package is installed via Package Manager
4. Connect a compatible VR headset (HTC Vive Pro or Meta Quest 2)
5. Build and deploy, or run in Play mode with XR simulation
