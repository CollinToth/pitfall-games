# Overview

This document serves as the software requirements specification for our Unity-based 2D platformer. The listed functional and non-functional requirements lay out what the game will be capable of and how it will behave, respectively. Each requirement has its own ID for traceability purposes. Each requirement will need to be fulfilled before completion of this project.

# Functional Requirements

1. Level design
    1. Levels shall be completable by the playable character crossing an endpoint on the stage.
1. Controls
    1. The game's controls shall be shown to the player before entering the first level and on the pause menu.
    1. The platformer game shall implement a playable character and have that character move in response to input from the user.
1. Interactions
    1. The game shall have a basic enemy with the ability to interact with the playable character.
    1. The playable character shall respawn on death.
    1. In the platformer, the character's attributes shall change in response to death from the game's enemies or the geometry of the level.
1. Menus
    1. The game shall have a pause menu.
    1. The game shall have a main menu that is displayed upon launch.
    1. The pause and main menus shall both have a volume slider.
    1. The pause and main menus shall both have an option to exit the game.
1. HUD
    1. The player's health shall be displayed on screen.

# Non-Functional Requirements

1. Performance
    1. The game shall target running at 60 frames per second.
1. Controls
    1. The game's controls shall be responsive.
    1. The game's controls shall be consistent with other games of its genre, so as to be intuitive to the user.
1. Difficulty
    1. Levels shall be challenging but not stressful.
    1. The usability of the platformer shall make it so that it is easy for people outside of the team creating it to understand how to use it.
    1. Levels shall scale up in difficulty as the game progresses.
    1. The game shall implement different enemy types that require different strategies.
1. Aesthetics
    1. Levels shall feel aesthetically distinct from one another through visual and musical theming.
    1. Different enemies shall have distinct differences so they are easy to tell apart.
