# Sky Parcel Delivery — Game Design Exercises

---

## Exercice: About the Game Design

**Goal / Rules / Core Loop (3 lines)**  
- **Goal:** Deliver fragile parcels across floating sky islands.  
- **Rules:** Fuel depletes mid-air; collisions crack parcels and reduce payout.  
- **Core Loop:** Plan jump → Boost between pads → Deliver → Refuel/Upgrade → Repeat harder routes.  

**Feedback (key action)**  
- Landing on a pad: pad glows cyan and a soft chime plays.  

**SCAMPER on favourite game (Hades)**  
- **Substitute:** Arenas → open sky routes  
- **Combine:** Dash + cast → mid-air dodge + boost  
- **Adapt:** Heat levels → wind tiers (lift/drag)  
- **Modify:** Long fights → short bursts + altitude puzzles  
- **Put to another use:** Boons → delivery contracts  
- **Eliminate:** Walls → focus on traversal  
- **Reverse:** Descending floors → climbing sky layers  

---

## Exercice: About the Game

**Player → Verb → Goal**  
- Player → Jetpack-glide → Deliver parcels safely.  

**Goal / Rules / Feedback**  
- **Goal:** Finish all deliveries intact.  
- **Rule 1:** Fuel only recharges at landing pads.  
- **Rule 2:** Hard hits crack parcels and lower payout.  
- **Feedback:** Crack sound + vignette effect when integrity drops.  

**Rule change + prediction**  
- *Rule change:* Fuel slowly regenerates mid-air.  
- *Effect:* Players focus more on precise landings and wind timing rather than constant refueling; gameplay feels more fluid.  

---

## Exercice: Pillars

- **Pillars:** Flow, Precision, Calm Risk  
- **Non-goal:** No grinding or arbitrary timers.  

---

## Exercice: MDA

**Mechanics → Feeling**  
1. Boost heat gauge → Tension  
2. Magnetic landing pads → Relief  
3. Shifting crosswinds → Alertness  

**Remove one mechanic:**  
- Without crosswinds, routes feel flat and less engaging; challenge and pacing decrease.  

---

## Exercice: Core Loop & Progression

**Core Loop:**  
Do → Plan route → Get → Payout / Fuel → Unlock/Prepare → Upgrades → Repeat → Harder routes  

**Progression for a new mechanic (Wind Riding)**  
1. **Teach:** Straight path, gentle crosswind, drift arrow.  
2. **Test:** Small gaps + short boosts vs mild wind.  
3. **Twist:** Gusts pulse; time boosts for vertical pads.  
4. **Master:** Combine vertical drafts, branching routes, and mid-air pad stops.  

---

## Exercice: Goals, Rules, Feedback, Rewards

- **Goal:** Deliver a three-parcel chain without cracks.  
- **Rule 1:** Boost overheats if held too long; cool on pads.  
- **Rule 2:** High-speed impacts lower integrity.  
- **Feedback (success):** Pad glows cyan + payout popup.  
- **Feedback (failure):** Fracture icon + crack SFX + short rumble.  
- **Cosmetic reward:** Unlock new contrail color after 5 flawless chains.  

---

## Exercice: Fair Challenge & Balance

- **Fairness tool:** Coyote time on pad edges — forgives late landings for beginners.  
- **Tuning knobs:**  
  1. Wind strength: Start softer → reduces early spills.  
  2. Fuel drain: Lower early → allows experimentation and learning.  

---

## Exercice: Level Design (Teach → Test → Twist → Master)

1. **Room 1 (Teach):** Short hop, stable wind; checkpoint at start (reduces frustration).  
2. **Room 2 (Test):** Three pads, mild wind; checkpoint after pad 2 (saves time).  
3. **Room 3 (Twist):** Vertical draft + moving pad; checkpoint before draft (allows retry).  
4. **Room 4 (Master):** Branching route + shifting gusts; checkpoint mid-route (prevents replaying whole level).  

---

## Exercice: UX & Accessibility

- **Accessibility features:**  
  1. High-contrast parcel integrity toggle (Settings → Accessibility)  
  2. Light auto-snap to pads toggle (Settings → Controls)  

- **Helpful in-game prompt:**  
> “Hold jump to charge boost; release early if heat nears red. Steer into the glowing pad for a safe landing.”
