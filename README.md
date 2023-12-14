# CPE-Rider-s-Quest

Rider’s Quest

Iakob Rigvava
Damiane Kapanadze
Aymen Elkhalil



Introduction

The project is an immersive 3D arcade auto-scroller game designed for Oculus Quest 2 headset. Players take on the role of an archer on horseback (or camelback), armed with a bow and arrow, giving the user the option to ride through the forest or desert. The player has to hit randomly generated targets before they get past them. If three targets get past them without getting hit the player loses. The speed of the player's mount increases based on time survived. The goal of the game is to get as many points as possible, which they get from surviving as long as possible and hitting the targets, hitting closer to the center gives more points.


Project Development

We utilized Unity and Oculus Quest 2 headset for our project.

The following are the descriptions of each script in the project:

------------------------------------------------------------------------------------------------------------

ArrowCollision (attached to the arrow prefab):
	OnTriggerEnter: 
Check if it hit the target, and increase the score accordingly to what it hit. Then stick to the arrow and get destroyed.

ArrowStick:
 Attaches the arrow to the target as a child. Destroys the rigidbody and box collider of the arrow.

DestroyThis: 
If it is a clone of the target controller, it gets rigidbody, thus starts falling, and the movement speed resets to 0. The object gets destroyed by the Move script later.

------------------------------------------------------------------------------------------------------------

AudioDifficutyController (attached to Music Controller):
	Start:
		Turn on and off music for hard mode and easy mode. (they are different)

------------------------------------------------------------------------------------------------------------

AudioManagerList (attached to AudioMenu -> Music and special effects sliders):
	Update:
		Change the audio volume based on the scroller

------------------------------------------------------------------------------------------------------------

CustomTransformer (attached to grab interactors on each bow)
	Edited one grab translate transformer
	BeginTransform:
Default transformer behavior, plus sets the status of the string to grabbed, and enables the arrow

EndTransform:
Sets the status of the string to not grabbed, disables the arrow, and resets its coordinates.

------------------------------------------------------------------------------------------------------------

Follow (attached to anything that needs to follow another object (menus, bow, arrow …)):
	Update: 
Set the position of one object based on the position of another and additional input form public variables from unity editor.
	
------------------------------------------------------------------------------------------------------------

GameplayMenuControll (attached to GameplayMenu):
	Start: 
		Handles controlling the gameplay menu: mode, right or left handed, biome

------------------------------------------------------------------------------------------------------------

GameplaySettings (attached to anything that uses gameplay settings):

Saves mode, biome, and dominant hand as static variables. Has functions to change each.

------------------------------------------------------------------------------------------------------------

GrabbedShare (attached to everything that uses grab):
	Stores static variables to save if the player is grabbing or not.

------------------------------------------------------------------------------------------------------------

HandControl (attached to HandControl):
	Start: enable and disable based on the dominant hand

------------------------------------------------------------------------------------------------------------

HealthController (attached to Canvas):
	Awake: 
Make sure that there is only one instance.
	
	Start: 
		Make dead heart images disappear and alive heart images appear on canvas.

	Kill:
Start from the last heart and check, if it is alive, change it to dead and exit. And check if the user ran out of lives or not. If the player ran out of lives, game over.

------------------------------------------------------------------------------------------------------------

HorseRunning (attached to the horse): 
Make the horse tilt back and forth so that it appears that it is moving.

------------------------------------------------------------------------------------------------------------

MenuManager (attached to every object or button that enables or disables another object or menu):
	Enable or disable an object from script 

------------------------------------------------------------------------------------------------------------

Move (attached to targets and environment objects(trees, bushes)):
Start:
If the object is Target and the gamemode is hard, add MoveTargets script to the object and change the movement of the targets (variable difficulty) by random.

Update:
Check if the object went past the player, and destroy it. If the object was a target, run kill function from HealthController script.
Check if the object is below the ground, destroy it. (this happens when the target gets hit by an arrow)
Otherwise move the object towards the player.

------------------------------------------------------------------------------------------------------------

MoveSpeed(attached for spawner Controller):
	Update:
		Increase the moveSpeed by speed and increase rate time between frames.

------------------------------------------------------------------------------------------------------------

MoveTargets(attached to targets):
	Start:
		Get initial x and y coordinates of the object.

	Update:
Check difficulty (set by Move script) and if it is 1, then move the target in circles. If it is 2, move the targets horizontally, and if it is 3, move it vertically. 

------------------------------------------------------------------------------------------------------------

PauseControll (attached to pauseRight and pauseLeft):
	Pause: set timescale to 0
	Resume: set timescale to 1

------------------------------------------------------------------------------------------------------------

SceneChanger (attached to startGame buttons in mainMenu, and quit button in pauseMenu):
	Loads scene specified by variable

------------------------------------------------------------------------------------------------------------

ScoreDisplay (attached to Canvas):
	Awake: 
Make sure that there is only one instance.

Start:
	Set the scoreText to “Score: 0”.

Update:
	Display time on Canvas in seconds.

	addScore:
Increase score with time dependent linear equation, round it to integer and display on Canvas

------------------------------------------------------------------------------------------------------------

Shoot_Arrow (attached to the Bow):
	Update:
		Shoot arrow from arrow emitter object

SpawnTargets (attached to spawner Controller):
	Update:
		Spawn targets with a time interval, randomly left and right, without spawning them directly in front of the player. Attach the Move script, and set movespeed set form MoveSpeed class.

	
------------------------------------------------------------------------------------------------------------

SpawnerTrees (attached to spawner controller):
	Update:
		Spawn 2 objects with a time interval. 
	Spawn:
Spawn them left and right randomly, but so that it doesn’t clash with the targets and player. Attach the Move script with isTree variable set to true, and movespeed set form MoveSpeed class.

------------------------------------------------------------------------------------------------------------

StartControl (attached to biome buttons in gameplayMenu):
	changeBiome: changes the start game button to the appropriate based on the biome. 

------------------------------------------------------------------------------------------------------------

TerrainSpawner  (attached to spawner controller):
	Start: 
		Create two Terrains in front of the user.

	Update: 
Move the terrains backward, creating the illusion of moving forward. When the center of the second terrain reaches the player, reset the terrains so that it continues infinitely.

------------------------------------------------------------------------------------------------------------

AudioManager (attached to sound scroller in audioMenu):
	Update:
Changes the volume of the audio listener to affect all audio in the game. 

------------------------------------------------------------------------------------------------------------

Quit ( attached to the exit button of the main menu):
	Quits the application

------------------------------------------------------------------------------------------------------------

The following are the assets utilized in the project:

3D models:
Trees:
https://assetstore.unity.com/packages/3d/vegetation/trees/lowpoly-trees-cartoon-free-251403

Desert:
https://assetstore.unity.com/packages/3d/environments/free-low-poly-desert-pack-106709
	
Arrows:
https://assetstore.unity.com/packages/3d/props/weapons/free-cartoon-weapon-pack-mobile-vr-23956

Horse:
https://sketchfab.com/3d-models/horse-e9f1f7d5684c4e8881eb24a1d57e71b3

Camel:
https://free3d.com/3d-model/camel-v03--20844.html

Planks:
https://brainchildpl.gumroad.com/l/dwkcuq?layout=profile

Other resources:
Oculus: 
https://developer.oculus.com/downloads/package/unity-integration/
https://developer.oculus.com/documentation/unity/unity-tutorial-hello-vr/

Pi: 
https://cpfevr.vercel.app/asset-store.html


Results and Evaluation

The project met and went above all our expectations, it came out very clean and high quality with a lot of options for customization. Many friends tested our game and each one enjoyed playing it, fulfilling our goal of making an enjoyable game.

We came across many challenges while working on this project, they are described below.

There were some problems with the arrow sticking to the target. At first, the arrow would stick to the target but not pearce though it, just levitate in the air near the target. So Pi suggested using OnTriggeerEnter instead of OnCollisonEnter, but then the arrow would stick the target in weird angles, or just go through it. It turned out that making the targets a bit wider fixed the problems.

We tried moving the Terrain, but it didn’t work at first. After spending a few hours, we figured out that the terrain would move if it was a child of another object, and the object was moving. So we made the terrain move by attaching it to another object as a child and moving the parent.

We had an issue while pulling the bow, the arrow that appeared sometimes did not follow the pulling hand, it stayed in the starting position. We checked every script that could have been the issue but could not find anything, plus these scripts were being used in other parts of the project with no issues. We spent a lot of time on this and the issue turned out to be elementary. The arrow still had its collider, so it was colliding with the bow and sticking to it, making it immovable. All we had to do was turn off the collider on the arrow.

We had another issue with the same arrow. The center of the 3D model for the arrow was in the middle of it, but when pulling the string we wanted the back end of the bow to be in the hand. We used our follow script for the arrow to follow the hand which rotates the object around its center when following another object’s rotation, so when the arrow was in front of the hand and it rotated around its center it did not align properly. The solution was to put the arrow inside an arrow container script, move it a bit so its back end aligns with the center coordinates of the container, and finally make the container follow the hand instead of the arrow.

We also had issues with hand pose detection, the tutorial we were following did not have the latest version of the SDK, so it did not have the finger state thresholds. When we did everything without the thresholds not only did it not work, the model of the hand also disappeared. Ultimately we had to research the issue in the documentation where we found out how the finger thresholds work and implemented it in the project, fixing the issue.

But the most frustrating part was when we had to import a scene from one project to another. It was the night before the presentation and all teammates were done with their part of the project and we just needed to import them into the same unity project. But both had a scene named game which got overwritten when imported. We had to redo the whole scene. It was a very maddening experience, but fortunately only the scene was affected, all other assets and scripts were saved, so even though it still took a lot of time, and nerves, we managed to finish rebuilding it in time.

The video demonstration of our project:
https://www.youtube.com/watch?v=hIuK7ZV5jTg

The github link for scripts used in the project:
https://github.com/akobi123/CPE-Rider-s-Quest/tree/main

The drive link for our full project:
https://drive.google.com/file/d/1UTERR3e04MqHr2VhaLCnAMjSO5FmmE7N/view?usp=sharing


Conclusion and Future work

The game is already playable, but what it lacks is replayability. We can add different game modes, for example, the mode that currently is in the game can be called the infinite mode where the goal is to get as many points as possible, and we can add a campaign mode that has levels in increasing difficulty, and the player has to beat one level to proceed to the next. We can also add variety to the game by adding different game elements described below. 

We can add different monsters that have the ability to attack the player as well by shooting projectiles at them that the player has to dodge or block. They might also have different movement patterns, some might remain on screen until killed. They can have different weak spots and armored spots, to act similar to the concentric circles of the targets that are currently in the game. They might also have multiple health points, needing multiple shots to be killed, or multiple spots needing to be destroyed for the monster to finally die.

We can add more weapons to the game, for example, swords and shields, magic wands, and so on. Each will have different ways to attack, for example, the sword can be swung to shoot an air blade towards the target, and the wand can shoot spells depending on a specific movement or a hand sign by the other free hand. We can also add different modes of attack for each weapon, like different arrows for the bow, different spells for the wand, or different swings for the sword.

We can also add different mounts to the game, with different speeds, some might even have special abilities, like auto-attacking targets sometimes, or giving enhancements to the player.

We can add power-ups in the game, for example, a health drop that heals the player when shot at, or a shield drop that protects the player from one attack, or weapon enhancement that enhances the player’s weapon in some way, or a speed drop that speeds up the player's mount.

We can also improve the visuals of the game. Add proper background for the menu scene, add variation in the terrain, like mountains and rivers in the forest biome, or sand dunes and pyramids in the desert biome. also add animations for the bow being drawn, and improve animations for the horse and camel.


Reflection on Learning

We learned how to develop games in Unity and work with game objects and prefabs. Working in Unity’s inspector was a new experience for us, we learned how to use public variables that can be accessed and modified through the inspector to change the behavior of the script, and public functions that can be given arguments from the inspector, for example, other game objects.

We learned how to work on C#, learned to implement different logic in scripts, like random target generation, collision detection, scoring system, menu management, settings that persist between scenes, audio management, and more. Got experience with object-oriented programming, specifically, we worked a lot with public variables and functions, as previously mentioned.

We learned to work with the Oculus Interaction SDK. Learned to use the OVR camera rig, and how to implement hand poke and hand grab interactions. Worked with hand pose detection and creating custom hand poses. Learned how to use and modify premade assets, like the sample menu. 

Learning a new language and editor while doing the project was a challenge. We got experience with reading documentation and following various tutorials, and using chatGPT to help and answer questions.

All in all, we got a lot of experience that will undoubtedly be useful in many situations. We hope to be able to continue working on the project and maybe even publish it in the future.
