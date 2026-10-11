# 1151VR-HW2-414262533-HCY
![ima] ([螢幕擷取畫面 2026-10-11 125212.png](https://github.com/DanielHsieh2533/1151VR-HW2-414262533-HCY/blob/main/%E8%9E%A2%E5%B9%95%E6%93%B7%E5%8F%96%E7%95%AB%E9%9D%A2%202026-10-11%20125212.png))

https://github.com/DanielHsieh2533/1151VR-HW2-414262533-HCY

https://youtu.be/Xc02eNrXFyM

說明:
自行繪製角色並用Unity的2D物件製作場景。使用 C# script 控制角色，此次為純粹按照腳本行動，玩家無法自行控制角色移動，並宣告移動速度及下一個目標點的索引值 (初始為0)。 C# 內 先在 player 內宣告關鍵點的 Vector2 陣列，將移動路徑的關鍵點位置事先存進陣列裡。在 Start 函式裡用 transform.position = startPos 來初始化位置，並用 Application.targetFrameRate = 60 將幀率設定成60。在Update函式中首先偵測目前索引是否還在範圍內，若還在則用 Vector2.Distance 計算當前位置與下一個目標點的距離，若小於0.1則判定到達(為解決 現在位置 == 目標位置 可能會因浮點數誤差而永遠判定沒到達)，目標索引+1，再次判斷索引是否在範圍內，若還在，使用 Vector2.MoveTowards 計算下一個位置，重複 Update 直到到達設定之終點位置。一開始關鍵位置只設了起點、起跳點、最高點、降落點，及終點，然而動作僵硬。最終在跳躍過程加入更多關鍵點，但距離真正的平滑跳躍仍有一段距離，此為之後可嘗試改善之挑戰。
