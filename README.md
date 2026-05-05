# NazAR Decor AR App

NazAR Decor is a Unity-based augmented reality retail application that lets users browse decor products, place them into a real-world space, and interact with them through product-specific AR controls.

## Project Overview

The app simulates an AR decor shopping experience. Users can:

- open the front page
- browse a product gallery
- select a product
- detect a horizontal surface
- place a 3D object in the environment
- use interactive controls for each product

## Products and Features

### 1. Desk Lamp
Features:
- Toggle lamp on and off
- View product information

### 2. Vanity Desk
Features:
- Change vanity color/material
- Show or hide the chair
- Open and close drawers

### 3. Gramophone
Features:
- Rotate the product
- Play or stop audio
- Reposition the object in AR

### 4. Ceramic Bowl
Features:
- Resize the bowl
- Trigger visual effects such as steam or soup-style effects

## Creative Feature

The main creative feature in this project is the vanity desk drawer interaction, which allows the user to open and close the drawers for a more realistic AR furniture experience.

## Application Flow

1. Front Page  
Displays the NazAR Decor logo and entry button.

2. Product Gallery  
Shows the available products for selection.

3. AR Product View  
Detects a plane, places the selected object, and displays product-specific action buttons.

## Main Scripts

- `ARButtonVisibilityManager.cs`
- `GalleryButtonHandler.cs`
- `SpawnPlaneProject.cs`
- `ActionButtons.cs`
- `LampController.cs`
- `VanityController.cs`
- `GramaphoneController.cs`
- `BowlController.cs`
- `ObjectVisibilityController.cs`
- `UIManagerScript.cs`

## Built With

- Unity
- AR Foundation
- XR Interaction Toolkit
- C#

## Demo and Submission Links

- Demo Video: [Watch the demo video here](https://drive.google.com/file/d/1GZJoDNR4PdFEsXCHkByunLaIud5u0_YA/view?usp=sharing)
- APK File: [Download the APK here](https://drive.google.com/file/d/1rwVFdfHIjizzZn0p5PgC9PUYe6PO2CyF/view?usp=sharing)
