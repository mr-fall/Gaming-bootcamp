# Daily Challenges

## Quick Reflection
**Question:** Pick any real-life system (e.g., traffic, school, restaurant). Write 3 sentences describing how feedback loops might exist in it.  

**Answer:**  
- When a restaurant receives positive reviews, more customers come in, which can increase wait times; longer waits then cause negative reviews, reducing demand later (**balancing loop**).  
- Increased demand encourages management to hire more staff or optimize seating, which shortens waits and improves reviews, creating a positive cycle (**reinforcing loop**).  
- Inventory depletion triggers restocking; if items run out, sales temporarily decrease until replenished, stabilizing demand (**balancing loop**).  

---

## Identify Emergence
**Question:** Think of one unexpected behavior you’ve seen in a game (e.g., an exploit or creative solution). Explain briefly why it happened.  

**Answer:**  
- In *Skyrim*, placing a bucket over a shopkeeper’s head allows players to steal freely. This emerges because NPC vision relies on line-of-sight detection, and collision/attachment logic didn’t account for covering the head.  

---

## System Categorization
**Question:** List 3 systems from different games and classify each as simple, complicated, or complex.  

**Answer:**  
- *Tetris*: simple — few rules and predictable outcomes.  
- *Dofus crafting*: complicated — many interdependent parts, deterministic but requires planning.  
- *Civilization*: complex — multiple interacting agents with unpredictable emergent behavior.  

---

## Mini Diagram Sketch
**Question:** Choose any game system (e.g., health). Identify its source, stock, and sink in one short paragraph.  

**Answer:**  
- **Source:** Health pickups, healing items, regen abilities, checkpoints (spawned via `Spawner` or dropped on enemy death).  
- **Stock:** Player `Health` component tracked numerically and visually in UI (`Slider` or `Image.fillAmount`).  
- **Sink:** Enemy attacks, hazards, fall damage, and damage-over-time effects decrease the player’s `Health` (`OnTriggerEnter` or `Update`).  

---

## Converter Thinking
**Question:** Name four resources that could be converted into something else in a crafting system (e.g., wood → plank).  

**Answer:**  
- Iron ore → Iron sword  
- Herbs → Potion  
- Animal hide → Leather  
- Leather → Armor/clothing  

---

## Identify a Loop
**Question:** Pick a loop from any game (e.g., XP and leveling) and describe if it’s reinforcing or balancing.  

**Answer:**  
- **Loop:** XP → Level up → Improved stats/gear → Faster kills → More XP  
- **Type:** Reinforcing  
- **Reason:** Each level increases player power, accelerating XP gain and progression.  

---

## Design Fix
**Question:** Pick a loop from any game and describe if it’s reinforcing or balancing.  

**Answer:**  
- **Loop:** XP snowball in open-world RPGs  
- **Type:** Reinforcing  
- **Reason:** Without control, over-leveling trivializes challenges. Designers introduce scaling or gated encounters to preserve challenge while rewarding progress, maintaining gameplay balance.  

---

## System Connection Map
**Question:** Pick any game and describe how two of its systems influence each other (e.g., combat and economy).  

**Answer:**  
- **System A:** Combat (enemy drops, XP, durability loss)  
- **System B:** Economy (shops, crafting costs, repairs)  
- **Interaction:** Combat yields currency and materials that feed into the economy; better gear increases combat efficiency, producing more resources—tempered by repair costs and consumable expenses.  

---

## Emergence Example
**Question:** Describe a surprising or unintended behavior you’ve seen in a game and what systems likely caused it.  

**Answer:**  
- In *Breath of the Wild*, players can chain electricity through metal weapons and dropped objects to solve puzzles in unintended ways. This emerges from physics systems, conductive material properties, and permissive puzzle validation that accepts any configuration meeting the electrical circuit condition.