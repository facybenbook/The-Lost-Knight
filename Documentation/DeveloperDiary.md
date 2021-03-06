# The-Lost-Knight
![](img\TheLostKnight.png)

<p align="center">
  <b>This is a development diary for my Unity project, The Lost Knight. This diary will be used to keep track of development and to outline my thoughts and ideas along the development process.</b><br>
</p>


## 7th October, 2018
This is the first entry in my developer diary. This diary will be kept to keep track
of the development of The Lost Knight. All code will be published here on this
Github repository. So far, I have a basic player and some platforms. I can move the
player using touch buttons which I have placed on the bottom of the screen.

The player can also shoot using a script which I wrote for my previous game 'Hattori' which I had already started on before being assigned this game.
I also spent a considerable amount of time working on the movement aspects of my first Unity game 'Zephyr'. I hope that I am able to successfully use some of these scripts such as moving platforms and more advanced player movement such as ascending slopes, being able to stick to walls and being able to jump from walls. 

My plan for today is try and implement these movement features from Zephyr into The Lost Knight and to also get a nice camera movement system for following the player.

## 8th October, 2018
Yesterday I tried to implement the movement features from Zephyr into The Lost Knight. However, I realized it would take a large amount of work to refactor everything to work with The Lost Knight and I realized that a lot of it wasn't really necesasry. While Zephyr's main focus was on the movement aspect of the game, I don't feel like this is necessary to implement into The Lost Knight. Thing's like moving platforms and wall jumping/wall sliding don't really have a place in a 2D Action game and it also wasn't specified in the design document so I have chosen to exclude these features and focus instead on other aspects of the design.

I did however manage to implement some nice camera movement into The Lost Knight with a simple one line script. It has a nice smoothing effect which can be adjusted and I am happy with it.

Today I hope to be able to make a sprite so I can start work on melee attacking and and animations for attacking and dashing as these are core gameplay mechanics and should be started on sooner rather than later.

<b>Update</b>
I managed to successfully make a sprite I was happy with along with an extremely basic 2 frame walking animation that currently looks awful but I will put more time into later. My idea for the sprite is that the player character will be monochrome and the backgrounds of each level will be unique and have a distinct color theme. This is to give the idea that the knight is 'lost' as the world he is currently in his very different from his own, hence the color contrasts.

## 9th October, 2018
Yesterday we created a player sprite and did a very awful walking animation. Today I would like to separate the player's sword from the model so it can have it's own collider and so it can be more easily animated. I also hope to set this up so that when the player hit's the attack button, their sword will swing and damage the enemy. I already have code for this but with the arrow projectile so hopefully this will be easy enough to implement.

## 10th October, 2018
Yesterday I successfully managed to implement a melee attack and a corresponding button for melee attacking. I was happy with the way it turned out with an easily adjustable attack radius. I will need to include an animation and some blood effects so it's easier for the player to know if they registered a hit or not. I could also try knocking back the enemy or making them stop their movement to better portray this.

Today I have a short break in which i'd like to get the enemy movement working correctly. In Hattori, the enemies just moved directly down but in The Lost Knight I'm going to have to give them some kind of behaviour.

<b>Update</b>
I have a new sprite for the player's sword that is larger making it easier to see. This is important as it will be the player's main weapon. I also have made enemies move between two points to simulate some kind of patrol behaviour. The next step for enemy behaviour will be to implement a script that moves the enemy towards the player when the player enters the enemies patrol 'radius'.

<b> Update 2 </b>
I feel like a lot of my code is a bit of mess so i'm going to go through and refactor/clean up the whole project before I proceed as I feel like this will only cause more problems down the road.

## 11th October, 2018
Today I successfully managed to refactor a lot of the code so that going forward my project and scripts are laid out in a more structured way. This will make it easier to add new components to the game without spending hours implementing them. I've also added a health bar system so for testing I can more acccurately see what's going.

## 16th October, 2018
I added some lighting effects and re-wrote some of the code. I still need to add attack animations and do some bug fixing on my attacking. I also need to add enemy patrolling and attacking. Once this is done, I can start on level design and then on enemy design. I hope to have this ready for the deadline on the 13th of November.

## 17th October, 2018
Now that i've added patrolling and chasing behaviour to the enemies it's time to work on animating the player and adding some particle effects to make the player's attack's feel more impactful. I would like to do this as this was a specific feature that was specified in the design document. To do this, I would like to add a blood particle effect that happens when the enemy is hit as well as knocking the enemy back a small bit when they are hit. This should let the player know when they have connected with their attack. I would also like to add an exclamation mark above enemies heads when the player comes within their aggro range. This should let the player know that the enemies have seen them and are going to attack them.

## 22 October, 2018
I've sucessfully added a game background for the tutorial level which I can use as a template for all other levels. I also have a blood animation/particle effect that plays when an enemy is hit. The next plan is to work on a pause menu that will display player's information such as their XP level, health and give them options for exiting the game and settings.