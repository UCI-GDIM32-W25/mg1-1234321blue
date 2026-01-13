[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Jeremiah Yang, he/him

Starting with the Player GameObject, in our plan, we defined it's attributes as the sprite and the # of seeds variable and it's methods as moving and being able to spawn seeds. Within the code, the sprite wasn't represented as it was already attatched to Player GameObject through the Sprite Renderer component, but the # of seeds memeber variable was present within the Player class as _numSeeds. On the actions side, I gave the Player the ability to move within the Update method, using the Translate method from the Transform component attatched to the Player GameObject. For spawning seeds, the Player class had the PlantSeed method, which I coded to check if the number of plants seeds the player had was more than 0. If this was true, the method would instatiate the seed where the player was, update the member variables _numSeeds, _numSeedsLeft, and _numSeedsPlanted accordingly. After updating these variables, the code would access the UpdateSeeds method from the PlantCountUI class. In our initial plan, we defined the UI as having the attributes of holding the variables of seeds remaining and planted and actions of updating the text in the game to match these changing variables. Within the actual code, while the actual integers aren't kept within the PlantCountUI class, the text member variables that will show in game are kept here, along with the aforementioned UpdateSeeds method, which updates the UI when the method is called to match the changing values of number of seeds left and number of seeds planted. 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
