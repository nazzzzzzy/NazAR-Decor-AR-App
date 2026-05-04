NazAR Decor AR Application
Project Overview
This project is an augmented reality retail application called Nazar Decor. The application allows the user to browse products, select a product, detect a horizontal plane, and place the selected 3D object into the real-world environment. Each product includes interactive features that demonstrate AR functionality and product manipulation.
Products and Implemented Tasks
Product	Required AR / UI Tasks Used	Implemented Features	Notes
Desk Lamp	Display product information; Toggle light	1. Light button toggles the lamp between off/on state.
2. Information button shows product information attached to the lamp or through the UI panel.	Used as one of the main decorative products in the AR scene.
Vanity Desk	Change product appearance; Toggle visibility of a product part; Creative feature	1. Color button switches the vanity between material/color options.
2. Show/Hide button toggles the visibility of the chair.
3. Drawers button opens and closes the vanity drawers as the creative feature.	Creative feature reflects realistic furniture usage.
Gramophone	Rotate product; Toggle audio; Reposition product	1. Rotate button rotates the gramophone.
2. Audio button plays/stops audio as well as spins the record.
3. Move button re-enables placement so the user can reposition the gramophone.	The record can spin while audio is active, depending on the final prefab setup.
Ceramic Bowl	Change size; Particle effects	1. Resize button switches the bowl between larger and smaller sizes.
2. Effects button is intended to toggle steam / soup-style effects for the bowl.	Used to demonstrate size manipulation and visual effects.
Creative Feature
The creative feature used in this project is the vanity desk drawer interaction. The user can open and close the drawers to simulate realistic furniture use in AR.
Application Flow
1. Front Page Canvas: Displays the Nazar Decor logo and a Products button.
2. Product Gallery Canvas: Displays four products the user can choose from.
3. AR Product Canvas: Detects a horizontal plane, places the selected object, and shows product-specific interaction buttons.
Main C# Scripts Used
ARButtonVisibilityManager.cs
GalleryButtonHandler.cs
SpawnPlaneProject.cs
UIManager.cs
ActionButtons.cs
LampController.cs
VanityController.cs
GramophoneController.cs
BowlController.cs
ObjectVisibilityController.cs

