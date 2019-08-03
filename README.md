# Geronimo

iOS application that loads and displays 3D models.



# How it works

Using this application requires access to the camera in order to use augmented reality.

1. Once the application is launched, please scan the room so that it can analyze your environment and generate flat surfaces (blue rectangles).
2. Once blue rectangles are present on the screen, you can press to position the gate at a reasonable distance.
3. Once the gate is positioned, press the "Deactivate AR Move" button and let your curiosity doing the rest.



# Use

- Perform a pinch to modify the scale of the object on the scene.
- Swipe to rotate the object on the scene. (can be improved by simulating a second finger at the opposite position of the user's finger and calculating the angle between both)

- The "Materials" button at the top left allows you to open the material menu:
  - Press the different colors of this menu to change the color of the object on the scene.
  

- The "Deactivate AR Move" / "Activate AR Move" button at the top of the screen allows you to activate/deactivate the repositioning of the entire portal, necessary to use the other features without moving the whole thing. (can be improved by automatically detect when it's a click that interact with an UI item and not with the scene)


- The "Models" button at the top right of the screen opens the models menu:
  - Press the desired model to load it on the scene.
  - The link at the bottom allows you to add a 3D object to the list; direct access to the file is required (example: FTP server) (this feature only works on the Unity editor).
  
# Details
  
The scenes used are these:
- Assets/UnityARKitPlugin/Examples/UnityARKitScene/UnityARKitScene.unity (for the AR scene)
- Assets/Scenes/scene_main (for the scene without AR)
