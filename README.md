1\.
Merge nie był fast-forward, ponieważ na mainie był nowy commit, tak jak i na branchu feature-max.
Historie były inne dla obu tych gałęzi, więc Git musiał je połączyć w jedną i utworzyć merge commit.



2\.

Rebase "prostuje" historię commitów, przenosząc je na koniec maina.
Merge łączy historię gałęzi i tworzy dodatkowy merge commit.



3\.

Konflikt został rozwiązany poprzez znalezienie trzeciej alternatywy dla dwóch kolidujących linijek w programie. Na gałęzi feature-conflict welcome message został zmieniony na "Buongiorno", natomiast na gałęzi main został zmieniony na "Konnichiwa". Rozwiązaniem konfliktu było wybranie trzeciej opcji i zmienienie welcome message na "Buenos Dias".

