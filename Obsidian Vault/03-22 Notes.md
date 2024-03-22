## Multiplayer Networking
- Read more about multiplayer networking
	- Try to become familiar with it

## Player
### Hands and Arms
- Try to read more about Joint components
	- Try to learn about the different parameters in Joint
	- there's a lot of joints in the Joint component

### Jumping

- Issue: when jumping Player seems to move faster
	- try to find a way to make player jump at a nice rate
		- could be updating jump script
		- could be altering the RigidBody component

### Movement

- Issue: when holding the keys (wasd) the forces make the player move faster
	- try to have the speed be maxed out when holding key
		- might need to alter the PlayerController script
- Need to rotate the player before they start moving
	- Issue: force is added no matter the direction the player is facing

## Platform
### Collision
- Issue: when player is on the side of platform, they can just chill there/do wild techs
	- reduce player techs when colliding with the sides of the platform