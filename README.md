# Eagle-Coin-
Endless Runner 2D Unity Game

# Mobile Endless Runner Game
## Overview
This is a 2D endless runner mobile game built in Unity where players control a character (with sprite animations) avoiding obstacles while collecting points. The game features mobile touch controls, obstacle spawning, score tracking, and persistent high scores.

## Game Features
### Core Mechanics
- Side-scrolling endless runner gameplay
- Touch-based joystick controls for vertical movement
- Obstacle avoidance
- Point collection system
- High score tracking
- Multiple character options (Player/PlayerB)

### Game Systems
#### Player Control System
- Mobile joystick controls (`MovementJoystick.cs`)
- Alternative bat control system with jump mechanics (`TheBat.cs`)
- Swipe detection for alternative control method (`SwipeDetection.cs`)
- Animated character sprites

#### Obstacle System
- Random obstacle spawning with customizable parameters (`SpawnObstacles.cs`)
- Two types of obstacles with different behaviors (`Obstacle.cs`, `Obstacle1.cs`)
- Collision detection with player
- Death effects and sound triggers

#### Score System
- Real-time score counting (`ScoreManager.cs`)
- Point pickup system (`PickupPoints.cs`)
- Advanced scoring with different point values (`ScoreScript.cs`)
- High score persistence between sessions
- Visual effects for point collection

#### Background Systems
- Infinite scrolling background (`LoopingBackground.cs`)
- Auto-scrolling camera (`CameraMovement.cs`)
- Persistent background music (`BackgroundMusic.cs`)

#### Menu Systems
- Main menu with play/quit options (`MainMenu.cs`)
- Pause menu with resume/quit functionality (`PauseMenu.cs`)
- Game over screen (`GameOver.cs`)
- Scene management (`SceneChange.cs`, `SceneChangeGame.cs`)

#### Audio System
- Sound effect management
- Volume control with persistence (`SoundManager.cs`)
- Background music that persists between scenes

## Technical Details

### Scene Management
The game uses multiple scenes:
- Main Menu
- Game Scene
- Additional game variations (referenced in scene change scripts)

### Script Interactions
1. **Player Control Flow**:
   - `MovementJoystick.cs` → `Player.cs`/`PlayerB.cs` → Character Movement
   - Touch input → `SwipeDetection.cs` → Player Response

2. **Obstacle System Flow**:
   - `SpawnObstacles.cs` → Creates Obstacles
   - `Obstacle.cs`/`Obstacle1.cs` → Handles Collision
   - Collision → Triggers Game Over

3. **Score System Flow**:
   - `ScoreManager.cs` → Tracks Time-Based Score
   - `PickupPoints.cs` → Handles Collectibles
   - `ScoreScript.cs` → Manages High Scores

### Save System
- High scores are saved using PlayerPrefs
- Volume settings persist between sessions
- Background music state is maintained across scenes

### Performance Considerations
- Object pooling for obstacles
- Efficient sprite animation system
- Optimized background scrolling
- Scene loading management

## Development Notes
- The game uses Unity's 2D physics system
- Sprite animation is handled through array-based animation
- Mobile-first design with touch controls
- Scene-based architecture for menu and gameplay separation

## Future Improvements
- Additional character variations
- Power-up system expansion
- Level progression system
- Achievement system
- Social features (leaderboards)

## Dependencies
- Unity 2D
- Unity UI system
- Unity Audio system
