# 簡易RPG小遊戲

這是一款回合制簡易 RPG 小遊戲，玩家需從三個角色中選擇兩個進行戰鬥。遊戲中包含戰鬥技能、寶具和敵人攻擊機制，透過計時器紀錄戰鬥時長，提供完整的 RPG 體驗。

## 遊戲流程

1. **開始遊戲**：
   - 畫面上有一個「開始遊戲」按鈕，按下後進入準備階段。

2. **準備階段**：
   - 玩家有 10 秒選擇兩個角色，點擊選中的角色按鈕變為綠色。
   - 時間到未選滿兩個角色時，自動選擇剩下的角色。

3. **戰鬥階段**：
   - 根據角色與敵人的速度決定行動順序。
   - 角色可進行普攻、技能和寶具攻擊：
     - **普攻**：50% 機率暴擊，造成雙倍傷害。
     - **技能**：每三回合可使用一次，效果為永久。
     - **寶具**：需要 100% Charge，發動後造成強力傷害。

4. **遊戲結束**：
   - 當兩個玩家角色全部陣亡時則戰鬥失敗。
   - 若擊敗敵人則戰鬥勝利，並顯示最終結果。

## 使用提示

- 各角色繼承基礎角色類別，並設計技能和寶具的額外效果。
- 戰鬥時顯示計時器來紀錄遊玩時長。
- 使用 MessageBox 提供行動和戰鬥結果的提示。