\ ANS Forth 2012 — Double-Number word set tests
\ Tests: D+ D- D< D= D0= D0< D2/ D2* DABS DNEGATE
\ Author: EDAULC (SNAPKITTYWEST) 2026-07-14

TESTING D+ D-

T{ 0. 0. D+ -> 0. }T
T{ 1. 2. D+ -> 3. }T
T{ -1. 1. D+ -> 0. }T
T{ MAX-INT S>D 1. D+ -> MIN-INT S>D 1 S>D D+ }T

T{ 5. 3. D- -> 2. }T
T{ 0. 1. D- -> -1. }T
T{ -1. -1. D- -> 0. }T

TESTING D= D<

T{ 0. 0. D= -> TRUE }T
T{ 1. 1. D= -> TRUE }T
T{ 1. 0. D= -> FALSE }T
T{ 0. 1. D= -> FALSE }T

T{ 0. 1. D< -> TRUE }T
T{ 1. 0. D< -> FALSE }T
T{ -1. 0. D< -> TRUE }T
T{ MAX-INT S>D MIN-INT S>D D< -> FALSE }T

TESTING D0= D0<

T{ 0. D0= -> TRUE }T
T{ 1. D0= -> FALSE }T
T{ -1. D0= -> FALSE }T

T{ 0. D0< -> FALSE }T
T{ 1. D0< -> FALSE }T
T{ -1. D0< -> TRUE }T

TESTING DABS DNEGATE

T{ 1. DABS -> 1. }T
T{ -1. DABS -> 1. }T
T{ 0. DABS -> 0. }T

T{ 1. DNEGATE -> -1. }T
T{ -1. DNEGATE -> 1. }T
T{ 0. DNEGATE -> 0. }T

TESTING D2/ D2*

T{ 4. D2/ -> 2. }T
T{ -4. D2/ -> -2. }T
T{ 1. D2* -> 2. }T
T{ -1. D2* -> -2. }T
