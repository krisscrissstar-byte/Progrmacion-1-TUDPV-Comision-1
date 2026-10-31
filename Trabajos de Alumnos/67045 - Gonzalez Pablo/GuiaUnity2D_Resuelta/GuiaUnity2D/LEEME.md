# Resolución — Guía de 20 Ejercicios Unity 2D (UTN FRT · Programación de Videojuegos I)

Cada carpeta tiene el/los script(s) del ejercicio. Copiá los `.cs` a `Assets/Scripts/` de tu proyecto.
**Importante:** el nombre del archivo debe coincidir exactamente con el nombre de la clase.

> **Versión de Unity:** los scripts usan `rb.linearVelocity` (Unity 6). Si usás Unity 2022 o anterior,
> reemplazalo por `rb.velocity`. Se usa el Input Manager clásico (`Input.GetAxis...`); en Unity 6 verificá en
> *Edit > Project Settings > Player > Active Input Handling* que esté en **Input Manager (Old)** o **Both**.

## Tags y reglas generales
- Crear los Tags en *Inspector > Tag > Add Tag*: `Player`, `Ground`, `Coin`, `Collectible`, `Key`, `Checkpoint`, `DeathZone`.
- Para que se disparen `OnTrigger...2D` / `OnCollision...2D`, **al menos uno** de los dos objetos debe tener `Rigidbody2D`.
- Los scripts del Player con físicas se complementan con `Comun/PlayerMovement2D.cs` (auxiliar, movimiento A/D) para poder probar los ejercicios 7–20.

---

## Ej. 1 — CursorFollower
Sprite (círculo) `CursorFollower` + script. Main Camera con Tag `MainCamera` y Projection `Orthographic`.

## Ej. 2 — PatrolMovement
Sprite `PatrolEnemy` + script. Crear vacíos `PointA` y `PointB` separados en X y arrastrarlos a los campos del script.
Se usa `Vector2.MoveTowards` y se alterna el destino al quedar a menos de `minDistance`.

## Ej. 3 — ScreenWrap
Sprite `PlayerShip` + `ScreenWrap` (+ `TopDownController` del Ej. 6 para moverlo). Con cámara Size 5 en 16:9, `limitX ≈ 9`, `limitY = 5`.

## Ej. 4 — ContinuousElevator
Sprite rectangular `ElevatorPlatform` en el piso + script. `maxHeight` es la coordenada Y donde vuelve al inicio (debe ser mayor a la Y inicial).

## Ej. 5 — LookAtTarget2D
Sprite `Turret` + script; arrastrar `Target` al campo. Si el sprite apunta hacia arriba en vez de a la derecha, poner `angleOffset = -90`.
Opcional: `TargetMover` en el Target para que gire en círculo.

## Ej. 6 — TopDownController
Sprite `TopDownPlayer` + script. Mover con WASD/flechas. Sin Rigidbody2D.

## Ej. 7 — PhysicsJump
- `Player`: Rigidbody2D (Constraints > Freeze Rotation Z), BoxCollider2D, Tag `Player`, `PhysicsJump` (+ `PlayerMovement2D`).
- `Ground`: BoxCollider2D, Tag `Ground`.
- `jumpForce` ≈ 7 con Mass 1 y Gravity Scale 1.

## Ej. 8 — GroundSensor
Hijo `GroundCheck` en la base del Player con BoxCollider2D **Is Trigger** (fino y un poco más angosto que el Player) + `GroundSensor`.
Se cuentan contactos para que no falle al pasar entre dos plataformas pegadas. Ver `isGrounded` en el Inspector durante Play.

## Ej. 9 — Trampoline
`Trampoline`: SpriteRenderer + BoxCollider2D + script (`bounceForce` ≈ 15). `Player` arriba con Rigidbody2D Dynamic + BoxCollider2D.

## Ej. 10 — FallingPlatform
`FallingPlatform`: BoxCollider2D + Rigidbody2D (Kinematic) + script. Player con Tag `Player` encima. Se usa `Invoke` y luego `bodyType = Dynamic`.

## Ej. 11 — GravityZone
`LowGravityZone`: Sprite cuadrado escalado, color con alfa (~0.3), BoxCollider2D **Is Trigger**, script con `customGravityScale = 0.2`.
Se guarda la gravedad original de cada Rigidbody2D en un `Dictionary` y se restaura al salir.

## Ej. 12 — CoinCollectible
`Coin`: Sprite círculo, CircleCollider2D **Is Trigger**, Tag `Collectible`, script. El Player necesita Tag `Player` y Rigidbody2D.

## Ej. 13 — DamageZone
`LavaZone`: BoxCollider2D **Is Trigger** + script (`damageInterval = 1`, `damageAmount = 10`).
En el Rigidbody2D del Player: **Sleeping Mode = Never Sleep** (si no, al quedarse quieto Unity deja de llamar `OnTriggerStay2D`).

## Ej. 14 — ScoreManager
`ScoreManager` en el Player (Rigidbody2D + BoxCollider2D). Varias `Coin` con Collider2D **Is Trigger** y Tag `Coin` (sin el script del Ej. 12).

## Ej. 15 — PlayerRespawn
- `Checkpoint`: BoxCollider2D Is Trigger, Tag `Checkpoint`.
- `DeathZone`: BoxCollider2D Is Trigger, ancho, debajo del nivel, Tag `DeathZone`.
- Player con Rigidbody2D + `PlayerRespawn`. Al reaparecer se anula la velocidad.

## Ej. 16 — ProjectileSpawner
1. Sprite chico `Bullet` + Rigidbody2D **Kinematic** (+ Collider2D Is Trigger opcional). Arrastrarlo a la carpeta del proyecto → Prefab. Borrarlo de la escena.
2. `Weapon` hijo del Player, con un hijo vacío `FirePoint` en la punta. Script en `Weapon`; asignar prefab y FirePoint.
3. Disparo: clic izquierdo (`Fire1`). La bala sale hacia el eje X local (rojo) del FirePoint.

## Ej. 17 — KeyInventory + DoorController
- `Key`: CircleCollider2D Is Trigger, Tag `Key`.
- `Door`: BoxCollider2D **sólido** (no trigger) + `DoorController`.
- Player: Tag `Player`, Rigidbody2D, `KeyInventory` (+ `PlayerMovement2D`).

## Ej. 18 — PushableBox
`HeavyBox`: Rigidbody2D Dynamic, **Mass = 10**, BoxCollider2D + `PushableBox` (congela rotación Z por código).
Player con Rigidbody2D Mass 1 movido por físicas (`PlayerMovement2D`). Si la caja casi no se mueve, bajar la fricción con un Physics Material 2D (Friction 0.2).

## Ej. 19 — Rebote con Physics Material 2D (sin código)
1. *Project > clic derecho > Create > 2D > Physics Material 2D* → `BouncyMaterial`. Friction = 0, Bounciness = 1.
2. `BouncyBall`: Sprite círculo + Rigidbody2D Dynamic + CircleCollider2D. Arrastrar `BouncyMaterial` al campo **Material** del CircleCollider2D (o del Rigidbody2D).
3. Suelo con BoxCollider2D. Soltar la pelota desde altura y dar Play.

Para que conserve la altura casi exacta: en el Rigidbody2D poner Linear Damping (Drag) = 0 y Collision Detection = Continuous.
Por la integración numérica puede variar levemente con el tiempo; es normal.

## Ej. 20 — PressureSwitch
- `PressurePlate`: BoxCollider2D Is Trigger + script; arrastrar `Bridge` al campo.
- `Bridge`: Sprite + BoxCollider2D (el script lo desactiva al iniciar).
- Caja (Rigidbody2D Dynamic) o Player para pisar la placa. Se cuentan los objetos encima: el puente solo se apaga cuando no queda ninguno.
