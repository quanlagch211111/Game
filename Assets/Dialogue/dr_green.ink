INCLUDE globals.ink

Hello there! #speaker:Quan #portrait:dr_green_neutral #layout:left #audio:animal_crossing_mid
-> main

=== main ===
Vậy hung khí là gì?
+ [Dao]
    ~ playEmote("exclamation")
    Ồ vậy ra đó là một <color=\#F8FF30>con dao</color> sao! #portrait:dr_green_happy
+ [Bình Hoa]
    Oh, thì ra đó là một  <color=\#5B81FF>chiếc bình hoa</color> à. #portrait:dr_green_sad

+ [Súng]
   Có lẽ hung khi là một  <color=\#5B81FF>Con dao</color>.#portrait:dr_green_sad

- Liệu có phải không, tôi nghĩ nó phải là một <b><color=\#FF1E35>khẩu súng</color></b>mới phải! #speaker:Kiên #portrait:ms_yellow_neutral #layout:right #audio:animal_crossing_high

~ playEmote("question")
Chúng ta cần xem xét ki hơn về hình tiết này #speaker:Quân #portrait:dr_green_neutral #layout:left #audio:animal_crossing_mid
+ [Yes]
    -> main
+ [No]
    Goodbye then!
    ~ playEmote("exclamation")
    -> END


