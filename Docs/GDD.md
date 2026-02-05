
> [!WARNING] This file is made for viewing and organizing in Obsidian.  
> Functionality like internal links, callouts, and notes may not work correctly in other editors.

# Game Title: TBD

> [!NOTE] Unity chosen for learning, Godot is objectively the better choice here tho.

**Engine of Choice:** Unity  
**Genre:** Rage, Precision Platformer  
**Platform:** Android  
**Target Audience:** Only Up fans  
**Vision Statement:** Minimal art, portrait layout, precision climbing in a mechanical dungeon; player is a glowing sphere with light wings on jump, no UI while climbing.

---

## 📑 GDD: Table of Contents

> **Core Gameplay:** [[#Core Gameplay|Jump]]  
> **Story / Characters:** [[#Story / Characters|Jump]]  
> **Mechanics:** [[#Mechanics|Jump]]  
> **Assets:** [[#Assets|Jump]]  
> **UI / UX:** [[#UI / UX|Jump]]  
> **Monetization:** [[#Monetization|Jump]]  
> **Notes / Ideas:** [[#Notes / Ideas|Jump]]

---

## Core Gameplay

Core Loop:

- Climb upward through precise jumps in mechanical dungeon segments.
- Player = glowing sphere; wings appear briefly on jump to indicate lift.
- Falling into hazards = instant restart.

Objectives / Win Conditions:

- Reach the top of each tower segment or the full dungeon.

Game Modes / Levels:

- Single-player tower climb
- Optional endless climb mode
- Levels consist of short, precise sequences with mechanical traps

Controls / Input:

- One-touch jump / swipe for movement
- Optional hold slows time slightly for micro-adjustments

Difficulty / Scaling:

- Brutally high; tight platform spacing and fast hazards.
- Later levels introduce more complex mechanical traps, moving platforms, retractable spikes.

---

## Story / Characters

**Synopsis / Premise:**

- Minimal story; progression is conveyed **through climbing and environment interaction**.
- Entire environment, hazards, and enemies are **composed of straight lines**, arranged in intricate patterns to form platforms, traps, and mechanical obstacles.
- Hazards and enemies are dynamic (moving, rotating, or interactive) but retain the **sharp, geometric line-based style**.
- Dark but pale-toned palette highlights the player and keeps the visual focus clear.

**World / Setting:**

- Mechanical dungeon aesthetic built entirely from **line-based geometry**: gears, platforms, spikes, walls, and moving hazards.
- Complex arrangements of lines create visually interesting tower segments without adding visual clutter.
- Player interacts with the environment dynamically; design communicates danger through **motion and shape**, not text.

**Main Characters:**

- Player: **glowing light sphere**, simple for clarity, easy to animate, matches jump-focused gameplay.
- Hazards: moving, rotating, or retractable, all **constructed from straight lines**, keeping visual style consistent.

**Story Progression / Quests:**

- Tower segments are procedural or hand-designed, focusing on **line-based geometry challenges**.
- Progression felt through mechanical puzzles, climbing sequences, and increasingly complex arrangements of lines.

---

## Mechanics

Core Systems:

- Physics-based climbing and jumping.
- Single-input control system.
- Instant-death hazards; falling resets player to start.

Rules / Constraints:

- No double jump.
- Wings appear only while ascending.
- Minimal visual feedback, relies on environmental cues.

Progression / Metrics:

- Height climbed per attempt.
- Death count / retries.
- Optional speedrun or time metrics.

Physics / Interaction:

- Gravity affects jump arcs.
- Player interacts with platforms and hazard collisions precisely.
- Wings provide temporary visual feedback, no gameplay effect.

---

## Assets

Visuals / Art Style:

- Dark mechanical dungeon, minimalist lighting.
- Player is glowing sphere; ephemeral wings animate on jump.
- Platforms are simple geometric shapes, gears, and pistons.

Audio / Music / SFX:

- Minimal industrial / ambient mechanical sounds.
- Subtle jump and hazard SFX.
- Focus on atmosphere and tension.

Animations / FX:

- Smooth jump arcs, wings fade in/out.
- Subtle mechanical motion for hazards.

Technical Notes:

- Portrait layout, Android optimized.
- Lightweight assets for low-end devices.

---

## UI / UX

Layout / HUD:

- No HUD during active climbing.
- Minimalist indicators only in menus or after failure.

Menus / Navigation:

- Start, pause, retry screens only.
- Quick restart from tower base.

Feedback / Notifications:

- Visual feedback comes from environment and player wings.
- Minimal sound cues for hazard proximity.

---

## Monetization

In-app Purchases / DLC:

- Optional cosmetic player colors or wing effects.

Ads / Premium Content:

- Optional rewarded ads to retry after fall.

Pricing / Revenue Model:

- Free-to-play core with cosmetic purchases.

---

## Notes / Ideas

- Consider subtle procedural variation in tower segments for replayability.
- Emphasize tension through minimalism: dark dungeon + light sphere.
- Player feedback through motion, sound, and wings rather than UI.
- Leaderboards and speedrun tracking optional.
